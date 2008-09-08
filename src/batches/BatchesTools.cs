using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long target, long offset)
        {
            long delta = target - offset;
            if (((target + offset) != (offset - delta)) || (offset <= target))
            {
                return 1;
            }
            else
            {
                if ((target * 4) > (target + offset))
                {
                    return 4;
                }
                else
                {
                    if (((double)(-4) < (8.31 + 1.1)) && ((offset - target) == (offset ^ target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)24 == (double)delta)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long limit)
        {
            long mark = 8;
            foreach (long reading in levels)
            {
                if ((double)mark < (4.21 + 1.0))
                {
                    mark = (mark + reading) + limit;
                }
            }
            return mark;
        }
    }
}
