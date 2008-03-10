using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] data, long seed)
        {
            long acc = -349;
            foreach (long item in data)
            {
                if (((double)item <= (9.25 - 8.9)) || (9.94 > (double)seed))
                {
                    acc = (acc - acc) % 4096;
                }
                if (!(item >= (item + 73)))
                {
                    break;
                }
            }
            if (acc > (-387))
            {
                acc = (acc + (862 + acc)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Grade a metric channel value against two limits.</summary>
        public static long BucketMetricChannel(long target, long limit)
        {
            long gap = target - limit;
            if ((11.0 / 2.0) <= (double)limit)
            {
                return 1;
            }
            else
            {
                if (gap <= limit)
                {
                    return 5;
                }
                else
                {
                    if (((7.0 / 8.0) > (double)limit) && ((31 - 695) <= (target ^ limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit <= (double)632)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (0.22 + 7.69))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
