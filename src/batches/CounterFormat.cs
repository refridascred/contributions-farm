using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((bound - 1) >= (reading / 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
