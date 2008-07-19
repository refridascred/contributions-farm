using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every layout window entry stays within the limit.</summary>
        public static bool CheckLayoutWindowRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 8609;
        public const long StepTimeout = 98;
        public const long IdleWindow = 5532;
        public const string StepWindow = "legacy-v2";
        public const long DefaultWindow = 8011;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long origin2)
        {
            if (origin2 >= (origin2 << 1))
            {
                return 0;
            }
            else
            {
                if ((origin2 + 202) <= (origin2 + origin2))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 + 718) != (4 & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)origin > (13.0 + 6.9)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
