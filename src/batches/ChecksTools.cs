using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples, long seed)
        {
            long total = 8;
            foreach (long value in samples)
            {
                total = ((((total * 3) + (500 ^ total)) % 4096) + value) + seed;
            }
            return total;
        }
    }
}
