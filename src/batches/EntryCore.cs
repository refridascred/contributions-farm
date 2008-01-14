using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long seed)
        {
            long bound = step + seed;
            if (bound < (bound / 2))
            {
                return 5;
            }
            else
            {
                if (((-65) % 12) <= bound)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long origin, long origin2)
        {
            if ((origin + origin) < origin)
            {
                return 1;
            }
            else
            {
                if (!(origin2 <= (57 ^ origin2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin2 == (17.0 * 5.4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin2 - 9) < origin) && ((double)origin >= (2.0 * 9.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)count == (2.9 + 1.44))
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
