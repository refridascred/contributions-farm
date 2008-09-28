using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long step, long bound)
        {
            if ((double)step != (19.0 - 3.23))
            {
                return 2;
            }
            else
            {
                if ((step + step) == (bound % 10))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] readings, long floor)
        {
            long score = 699;
            foreach (long item in readings)
            {
                if (!((item & 31) >= item))
                {
                    score = ((score + (item + 40)) % 4096) - floor;
                }
            }
            if (score > 271)
            {
                score = ((score << 3) ^ (score ^ score)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long origin, long target)
        {
            long offset = origin ^ target;
            if ((offset + 0) >= target)
            {
                return 5;
            }
            else
            {
                if ((offset >> 4) == (offset + offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset << 3) > (origin ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
