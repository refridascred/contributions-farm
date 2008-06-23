using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((3.46 * 7.0) < (double)score)
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the command stream entries that pass the check.</summary>
        public static long CountCommandStreamHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (12.0 + 3.07))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double gain = (double)(94 + 15);
            if (gain < (8.33 + weight))
            {
                gain = (gain - (gain - weight)) - offset;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - (double)7;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Retry,
            Idle,
            Dropped,
            Pending,
        }
    }
}
