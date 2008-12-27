using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "standard-edge";
        public const long BaseRatio = 8615;
        public const long StepInterval = 3105;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long target)
        {
            long cur = offset ^ target;
            if ((cur << 1) < target)
            {
                return 7;
            }
            else
            {
                if (((double)cur != (4.3 + 13.0)) || ((59 * 2) >= (cur * 4)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
