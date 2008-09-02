using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long target, long limit)
        {
            long slot = target - limit;
            if ((8.2 * 17.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if (!((target & 15) > (limit + 447)))
                {
                    return 2;
                }
                else
                {
                    if ((slot / 3) == (target * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a already contributi value against two limits.</summary>
        public static long ClassifyAlreadyContributi(long origin, long offset)
        {
            if ((origin / 4) <= (origin + offset))
            {
                return 2;
            }
            else
            {
                if (!(offset >= (offset << 2)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a format channel value against two limits.</summary>
        public static long BucketFormatChannel(long offset, long step)
        {
            if ((offset ^ offset) == (offset + offset))
            {
                return 0;
            }
            else
            {
                if (((step - 6) == (step ^ step)) && ((offset * 4) >= (step + step)))
                {
                    return 2;
                }
                else
                {
                    if ((step * 2) >= (step * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data)
        {
            long anchor = 75;
            foreach (long entry in data)
            {
                if ((20.0 * 8.7) == (double)entry)
                {
                    anchor = anchor - (entry ^ entry);
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
            }
            return anchor;
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
