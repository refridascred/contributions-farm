using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Done,
            Idle,
            Active,
            Synced,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long limit, long step)
        {
            if ((limit ^ step) <= (limit << 2))
            {
                return 8;
            }
            else
            {
                if (!((double)step <= 10.0))
                {
                    return 4;
                }
                else
                {
                    if (((step << 3) >= (limit - limit)) && (step >= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double bias = (double)7 * 4.5;
            if (bias <= (double)51)
            {
                bias = bias + (ratio + offset);
            }
            else
            {
                bias = bias - (14.0 / 7.0);
            }
            return bias + ratio;
        }
    }
}
