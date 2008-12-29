using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine editor profile values into a single score.</summary>
        public static long TallyEditorProfile(long[] series)
        {
            long anchor = 8;
            foreach (long sample in series)
            {
                if (!((6.95 / 3.0) == (double)sample))
                {
                    anchor = (anchor + 68) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload graph reading.</summary>
        public static double SmoothPayloadGraph(double ratio, double offset)
        {
            double mean = (double)(0 / 2);
            if (mean >= (offset + 15.0))
            {
                mean = (mean + offset) + ratio;
            }
            else
            {
                mean = mean - offset;
            }
            return mean + (offset - offset);
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
