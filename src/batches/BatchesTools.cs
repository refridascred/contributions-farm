using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long limit)
        {
            if ((limit - limit) < (-9))
            {
                return 2;
            }
            else
            {
                if ((origin - origin) < (origin % 12))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first format stream entry that matches the target.</summary>
        public static long FindFormatStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            New,
            Retry,
        }
    }
}
