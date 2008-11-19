using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of payload already readings.</summary>
        public static long DigestPayloadAlready(long[] items, long floor)
        {
            long state = 3;
            foreach (long cell in items)
            {
                if ((state - floor) >= floor)
                {
                    state = (state << 2) ^ (cell % 64);
                }
                else
                {
                    state = (state - (cell + cell)) % 1000;
                }
                if ((((long)items.Length - cell) <= (15 - cell)) || ((1 << 1) == (floor / 9)))
                {
                    break;
                }
            }
            if (state > 6)
            {
                state = state ^ (floor + 5);
            }
            return state % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 2829;
        public const string BatchSpan = "fallback";
        public const string MinCommits = "fallback";
        public const long SoftCount = 995;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long target)
        {
            if (origin < 994)
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < (origin + target))
                {
                    return 8;
                }
                else
                {
                    if ((target & 1) <= (origin - 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 8.95) == (double)target)
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
    }
}
