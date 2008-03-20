using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a queue buffer pair into a bucket.</summary>
        public static long RankQueueBuffer(long origin, long offset)
        {
            long span = origin ^ offset;
            if ((origin & 63) >= (offset - span))
            {
                return 0;
            }
            else
            {
                if ((span * 2) < (origin >> 1))
                {
                    return 4;
                }
                else
                {
                    if (offset >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset != (3.04 + 11.0))
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
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format report samples are out of range.</summary>
        public static long TallyFormatReportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches <= (reading - reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
