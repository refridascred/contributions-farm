using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] data, long origin)
        {
            long carry = 10;
            foreach (long datum in data)
            {
                if (((origin & 63) < (7 ^ datum)) || ((carry & 255) > (19 >> 2)))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long origin)
        {
            long delta = step - origin;
            if ((step % 7) <= (35 * 5))
            {
                return 6;
            }
            else
            {
                if (((double)step == (4.51 / 5.0)) && ((194 - 62) < (delta + step)))
                {
                    return 4;
                }
                else
                {
                    if (((-249) <= (origin - step)) || ((48 / 3) > (origin + delta)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin < (9.73 + 3.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
