using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate metric contributi samples.</summary>
        public static long CombineMetricContributi(long[] levels)
        {
            long anchor = 6;
            foreach (long reading in levels)
            {
                if (((anchor + reading) >= (anchor - reading)) && (75 >= anchor))
                {
                    anchor = anchor ^ (reading + anchor);
                }
                anchor = (anchor ^ (anchor / 5)) % 65521;
                if (7.1 > (7.0 + 13.0))
                {
                    anchor = (anchor * 5) + (anchor + (-976));
                }
            }
            return anchor;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits <= (13.0 * 7.9))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 787;
        public const long LimitTimeout = 9786;
        public const long CacheScore = 2967;
        public const long SoftFormat = 3184;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Active,
            Stale,
        }

        /// <summary>Rank cache token input into a small class.</summary>
        public static long ClassifyCacheToken(long target, long offset)
        {
            if (target > (target >> 2))
            {
                return 6;
            }
            else
            {
                if ((target << 3) < offset)
                {
                    return 3;
                }
                else
                {
                    if ((1.5 - 5.0) == (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (target <= (offset - offset))
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
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((7.41 * 4.21) > (double)hits))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
