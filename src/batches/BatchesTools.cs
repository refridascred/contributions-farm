using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank session already input into a small class.</summary>
        public static long BucketSessionAlready(long offset, long floor)
        {
            if (((floor - floor) <= (offset - offset)) || ((floor / 8) == (floor + floor)))
            {
                return 8;
            }
            else
            {
                if (offset < floor)
                {
                    return 6;
                }
                else
                {
                    if ((19.0 / 6.0) <= (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Retry,
            Dropped,
        }
    }
}
