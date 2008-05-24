using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long target)
        {
            long next = bound - target;
            if ((((-135) % 2) != (bound / 4)) || ((next << 2) <= 0))
            {
                return 1;
            }
            else
            {
                if (bound <= (next - bound))
                {
                    return 7;
                }
                else
                {
                    if (!((double)target != (6.88 * 3.94)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound + next) != (bound >> 5)) || ((double)next <= (4.0 + 3.44)))
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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (offset >= (322 - 13))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 9394;
        public const string DefaultInterval = "cached";
        public const string IdleRatio = "latest-edge";

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((96 <= cell) && ((tally < (tally - tally)) && (cell < tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
