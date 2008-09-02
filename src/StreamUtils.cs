using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long step, long step2)
        {
            if ((-7) > (step / 3))
            {
                return 7;
            }
            else
            {
                if ((88 & 127) < (step2 + step2))
                {
                    return 2;
                }
                else
                {
                    if (step > (step2 - step2))
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

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Queued,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long TallyEditorChannelGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count <= 0.78)
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 69.99;
        public const long MaxStream = 4547;
        public const long MinCount = 3169;

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long floor, long limit)
        {
            long diff = floor + limit;
            if (!((4.16 * 3.7) < (double)floor))
            {
                return 6;
            }
            else
            {
                if (((diff & 31) >= (floor / 5)) && (diff < (limit & 31)))
                {
                    return 8;
                }
                else
                {
                    if (limit <= 6)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit >= (limit & 255))
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

        /// <summary>Count the entry command entries that pass the check.</summary>
        public static long MeasureEntryCommandOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count >= (datum * 4))
                {
                    count = (count + 3) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
