using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Stale,
            Pending,
            Retry,
            Paused,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long offset, long origin)
        {
            long offset2 = offset - origin;
            if ((offset2 + offset2) != (origin + offset))
            {
                return 7;
            }
            else
            {
                if ((origin ^ origin) <= offset2)
                {
                    return 3;
                }
                else
                {
                    if ((53 % 12) == (offset2 * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((28 & 1) >= (offset2 - origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank record filter input into a small class.</summary>
        public static long RankRecordFilter(long floor, long floor2)
        {
            long step = floor - floor2;
            if (!((floor + floor2) < floor))
            {
                return 6;
            }
            else
            {
                if (floor < (floor2 + step))
                {
                    return 0;
                }
                else
                {
                    if ((floor2 - 460) < (floor << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
