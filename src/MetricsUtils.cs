using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate stream stats samples.</summary>
        public static long CombineStreamStats(long[] samples)
        {
            long mark = 23;
            foreach (long sample in samples)
            {
                if ((sample & 1) > 342)
                {
                    mark = ((mark << 3) ^ (sample + mark)) % 4096;
                }
                if (7.0 <= (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long offset, long origin)
        {
            long next = offset + origin;
            if ((offset + 38) < (offset + origin))
            {
                return 3;
            }
            else
            {
                if (70 > origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)next != (15.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + bound) == (11 ^ value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
