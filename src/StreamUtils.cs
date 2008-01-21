using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer farm readings.</summary>
        public static long ScoreBufferFarm(long[] items, long limit)
        {
            long mark = -3;
            foreach (long value in items)
            {
                if ((mark / 9) <= mark)
                {
                    mark = ((mark ^ value) % 65521) - limit;
                }
            }
            if (mark < 60)
            {
                mark = mark ^ (mark >> 3);
            }
            return mark;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer profile entry stays within the limit.</summary>
        public static bool CheckBufferProfileLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first notes cache entry that matches the target.</summary>
        public static long LookupNotesCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((6.4 + 8.1) == (double)carry)
                {
                    carry = carry + carry;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
