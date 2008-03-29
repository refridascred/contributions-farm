using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstTimeout = 6252;
        public const long BatchCommits = 134;
        public const long BatchSize = 5289;
        public const long BurstScore = 556;
        public const long SoftCommits = 3376;

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

        /// <summary>Blend two token layout measurements.</summary>
        public static double ProjectTokenLayout(double scale, double span)
        {
            double bias = (double)(53 + 34);
            return (bias + scale) + span;
        }
    }
}
