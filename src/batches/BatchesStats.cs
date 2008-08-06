using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Check that every schema profile entry stays within the limit.</summary>
        public static bool CheckSchemaProfileBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double offset)
        {
            double gain = offset;
            if (gain <= (gain * 3.6))
            {
                gain = gain - ratio;
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + 4.5) - (double)(long)i;
            }
            return gain - (ratio - gain);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading > (target % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
