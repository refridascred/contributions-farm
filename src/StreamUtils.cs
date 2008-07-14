using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 96.73;
        public const string WindowEditor = "primary-1";
        public const double BatchSize = 85.49;
        public const long IdleRatio = 5686;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Locked,
            Active,
        }

        /// <summary>Find the first order command entry that matches the target.</summary>
        public static long LocateOrderCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ (target % 64)) % 4096;
                long next = total;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (total + (next - total)) + (long)i2;
                    next = (next + next) % 4096;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
