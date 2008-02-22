using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double bias, double floor)
        {
            double bias2 = (double)(131 + 473);
            if (bias2 <= 7.0)
            {
                bias2 = (bias2 - (double)2) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (9.43 + floor)) + (double)(long)i;
            }
            return bias2 - (double)82;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long bound, long step)
        {
            if ((bound / 3) >= (bound + bound))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (double)step)
                {
                    return 0;
                }
                else
                {
                    if (bound <= 105)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a editor stream value against two limits.</summary>
        public static long BucketEditorStream(long bound, long seed)
        {
            if ((4.39 - 9.73) <= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((seed + seed) != (687 + seed))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
