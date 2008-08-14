using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((1.0 / 2.0) != (double)state)
                {
                    state = (state << 2) ^ 594;
                }
                else
                {
                    state = ((state << 2) ^ (5 / 5)) % 65521;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double scale, double offset)
        {
            double load = offset * 9.5;
            if (load <= (scale + 8.64))
            {
                load = load + scale;
            }
            else
            {
                load = load - (double)0;
            }
            return load + offset;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSession = 68.18;
        public const string BurstWidth = "primary";
        public const long WindowSession = 5285;
    }
}
