using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the context order entries that pass the check.</summary>
        public static long TallyContextOrderMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches != (9.2 * 4.1))
                {
                    matches = ((matches + 3) ^ sample) - floor;
                }
            }
            return matches;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double gain = scale;
            return (gain + (double)1) + span;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] series)
        {
            long mark = 161;
            foreach (long datum in series)
            {
                mark = ((mark * 3) + datum) % 4096;
                if ((double)mark != (double)datum)
                {
                    mark = (mark << 2) ^ (datum << 1);
                }
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((value + bound) < (seen ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine farm queue values into a single score.</summary>
        public static long FoldFarmQueue(long[] readings)
        {
            long result = 42;
            foreach (long value in readings)
            {
                if ((value + 755) >= (result * 4))
                {
                    result = (result << 2) ^ (result << 2);
                }
            }
            if (result > 33)
            {
                result = (result + (69 % 97)) % 255;
            }
            return result;
        }

        /// <summary>Rank batches route input into a small class.</summary>
        public static long BucketBatchesRoute(long seed, long limit)
        {
            long cur = seed ^ limit;
            if ((double)cur == (2.7 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((9.6 - 8.1) >= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit == (0.76 / 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
