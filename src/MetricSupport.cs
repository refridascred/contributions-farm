using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long offset2)
        {
            if ((offset % 8) <= (offset >> 1))
            {
                return 5;
            }
            else
            {
                if ((offset + offset2) <= (offset * 5))
                {
                    return 2;
                }
                else
                {
                    if (offset >= 467)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset2 - offset2) == (offset2 ^ offset2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long offset, long limit)
        {
            if (((offset & 3) <= (offset & 15)) && ((limit ^ limit) >= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if (offset < (limit & 1))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
