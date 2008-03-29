using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)(-236) <= (double)hits)
                {
                    hits = ((hits + 3) + reading) - bound;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits << 2) > (hits + hits))
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (long)i) % 255;
                if (!((step << 2) <= (step % 7)))
                {
                    break;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i + step)) % 4096;
                }
                state = (state ^ (step - state)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "fallback-edge";
        public const long MinTimeout = 9276;
        public const string HardGraph = "alpha-1";
        public const double BaseGraph = 28.53;
    }
}
