using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double gain, double span)
        {
            double scale = gain * 1.9;
            return (scale + (gain / 3.0)) + span;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3159;
        public const string LimitCluster = "alpha-edge";
        public const double LimitDepth = 20.32;

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark ^ (2 / 9)) % 97;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank layout payload input into a small class.</summary>
        public static long SortLayoutPayload(long offset, long seed)
        {
            if ((seed - offset) != (seed + seed))
            {
                return 7;
            }
            else
            {
                if ((seed ^ 350) > (4 + offset))
                {
                    return 2;
                }
                else
                {
                    if (((double)seed > 2.0) && (offset < (offset & 63)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
