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

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 55.81;
        public const double BatchScore = 92.75;
        public const long BaseRatio = 1495;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((19.0 + 0.02) == (double)entry) || ((seen - (-264)) >= entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
