using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long offset, long seed)
        {
            if (!((seed / 3) != (seed / 8)))
            {
                return 5;
            }
            else
            {
                if ((72 / 4) == (2 ^ seed))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleInterval = "fallback-edge";
        public const string LimitOrder = "staging";
        public const string MaxSpan = "standard";
        public const double BurstTimeout = 18.96;
        public const long MinRatio = 459;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Count the profile schema entries that pass the check.</summary>
        public static long TallyProfileSchemaHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((sample & 31) <= (sample & 1)) && ((matches + sample) > 49)) && !((matches / 3) != (matches + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
