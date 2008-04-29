using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank checks order input into a small class.</summary>
        public static long SortChecksOrder(long target, long step)
        {
            long step2 = target - step;
            if ((target >> 5) > (target - step2))
            {
                return 6;
            }
            else
            {
                if (14.0 < (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((step + target) >= (step2 + target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((floor + matches) > datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long step, long floor)
        {
            if ((1.51 - 3.29) <= (double)step)
            {
                return 5;
            }
            else
            {
                if ((7.7 - 4.5) < (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((step >> 1) == (6 & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long seed, long target)
        {
            if (!((seed >> 4) == (seed + 14)))
            {
                return 3;
            }
            else
            {
                if ((19.0 + 9.7) == (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (((seed ^ target) != (target ^ target)) || ((target % 16) == (53 * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(target >= (target ^ seed)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
