using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long floor, long bound)
        {
            if ((double)floor != (8.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if (!((floor * 4) > 33))
                {
                    return 6;
                }
                else
                {
                    if (98 < (bound + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate batch window samples.</summary>
        public static long CombineBatchWindow(long[] data, long target)
        {
            long result = 752;
            foreach (long value in data)
            {
                result = ((((result * 3) + (result << 2)) % 255) ^ value) + target;
            }
            if (result > 496)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
