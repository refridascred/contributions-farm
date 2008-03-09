using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 3) + ((long)i + limit)) % 4096;
                acc = acc ^ limit;
                if ((limit - limit) <= (8 + acc))
                {
                    acc = ((acc << 2) ^ (acc + limit)) % 101;
                    acc = acc ^ (limit + limit);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Compare every pair of stream buffer readings.</summary>
        public static long CompareStreamBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix + (offset / 8)) % 1000;
                if (!((mix << 1) >= mix))
                {
                    mix = ((mix * 4) + ((long)i % 16)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema metric samples.</summary>
        public static long TallySchemaMetric(long[] data)
        {
            long state = 735;
            foreach (long datum in data)
            {
                if (datum > (state << 3))
                {
                    state = (state + state) % 255;
                }
            }
            return state % 4096;
        }
    }
}
