using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long floor)
        {
            if ((floor + origin) > (origin ^ origin))
            {
                return 7;
            }
            else
            {
                if ((floor >> 2) >= (origin ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > (8.0 + 9.65))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.11 * 14.0) > (double)origin)
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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((double)seen >= (3.6 * 2.0)) && ((seen + seen) == (seen * 4)))
                {
                    seen = ((seen + 2) + datum) + floor;
                }
            }
            return seen;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark + ((long)i % 8)) % 101) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((reading ^ matches) < limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Active,
            Draft,
            Ready,
            Paused,
        }
    }
}
