using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Done,
            Active,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "local-v2";
        public const long BurstProfile = 4352;
        public const long BaseProfile = 5477;
        public const string MinRatio = "staging";

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache schema entries.</summary>
        public static long FoldCacheSchema(long[] readings, long step)
        {
            long sum = 844;
            foreach (long sample in readings)
            {
                sum = (((sum ^ (sum >> 5)) % 97) + sample) + step;
            }
            return sum;
        }
    }
}
