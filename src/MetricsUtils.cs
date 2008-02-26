using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long bound)
        {
            if (bound > (bound & 1))
            {
                return 5;
            }
            else
            {
                if ((bound >= origin) && ((915 + 889) >= bound))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long offset, long step)
        {
            if ((offset - 3) >= (offset - offset))
            {
                return 1;
            }
            else
            {
                if ((step + offset) <= (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((2.35 / 8.0) == (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset & 15) <= offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long seed)
        {
            long slot = target + seed;
            if (slot > (slot + seed))
            {
                return 7;
            }
            else
            {
                if ((seed * 3) <= seed)
                {
                    return 1;
                }
                else
                {
                    if (seed <= 12)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((69 / 8) == (target >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double gain, double span)
        {
            double ratio = (span / 5.0) + (double)(-87);
            return (ratio - 13.0) + gain;
        }
    }
}
