using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                if ((acc < 2) && ((long)i < target))
                {
                    acc = ((acc * 3) + target) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support graph readings.</summary>
        public static long MatchSupportGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 4364;
        public const string MinWindow = "fallback";
        public const long BurstInterval = 63;
        public const long MaxCount = 56;
    }
}
