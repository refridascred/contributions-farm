using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long bound, long origin)
        {
            long offset = bound ^ origin;
            if ((origin >> 5) > 94)
            {
                return 4;
            }
            else
            {
                if (bound > (offset ^ origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset >= (19.0 / 7.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound <= (origin & 255))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long floor, long offset)
        {
            long next = floor + offset;
            if ((next > (offset % 60)) && ((next * 2) < (offset ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((offset + next) >= (227 + offset))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
