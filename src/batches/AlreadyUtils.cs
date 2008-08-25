using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((double)bound <= (double)(long)i)
                {
                    score = (score ^ (bound << 1)) % 4096;
                }
                score = (score << 3) ^ ((long)i >> 1);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen << 2) > 0)
                {
                    seen = ((seen + 2) - value) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 2.99;
        public const long HardEditor = 1234;
        public const string BatchEditor = "fallback-1";

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Active,
            New,
            Ready,
            Failed,
        }
    }
}
