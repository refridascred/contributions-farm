using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a contributi buffer figure with a bias.</summary>
        public static double ProjectContributiBuffer(double scale, double floor)
        {
            double mean = floor;
            if (mean < (double)61)
            {
                mean = (mean - (mean + 2.9)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Grade a already stats value against two limits.</summary>
        public static long ClassifyAlreadyStats(long origin, long bound)
        {
            long offset = origin ^ bound;
            if ((bound ^ origin) < (offset / 3))
            {
                return 8;
            }
            else
            {
                if ((428 % 60) < (offset ^ offset))
                {
                    return 2;
                }
                else
                {
                    if (((987 * 2) <= (bound ^ offset)) && ((1.1 + 0.5) != (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                mix = (((mix << 3) ^ mix) % 255) - cell;
            }
            return mix;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
