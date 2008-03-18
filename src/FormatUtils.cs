using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = (state * 2) + ((long)i + state);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark << 2) ^ (floor & 127)) - (long)i2;
                    mark = mark - mark;
                }
                mark = (mark - ((long)i - mark)) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxRatio = 1786;
        public const long MaxGraph = 2948;
        public const long CacheGraph = 2832;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long step)
        {
            if ((step + step) > (step - limit))
            {
                return 4;
            }
            else
            {
                if ((6.49 + 1.1) == (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((origin & 31) == ((-168) ^ matches)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
