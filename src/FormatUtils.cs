using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long floor)
        {
            long mix = 31;
            foreach (long value in data)
            {
                if ((248 << 3) < (mix * 4))
                {
                    mix = (((mix * 5) + (floor & 255)) % 65521) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Synced,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long seed, long limit)
        {
            if (((-1) - 91) <= (limit ^ seed))
            {
                return 5;
            }
            else
            {
                if ((62 ^ seed) <= seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed + 3) == (seed << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((79 % 2) >= limit))
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

        /// <summary>Combine stream metric values into a single score.</summary>
        public static long TotalStreamMetric(long[] samples)
        {
            long mix = 98;
            foreach (long item in samples)
            {
                if ((mix << 1) < item)
                {
                    mix = ((mix << 3) ^ ((-302) * 3)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Retry,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Derive the next buffer profile value from a seed.</summary>
        public static long SeriesBufferProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if ((6.9 / 7.0) < (double)(long)i)
                {
                    mark = (mark + (132 + 58)) % 65521;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
