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

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = (result ^ ((-877) & 3)) % 255;
                result = result ^ ((long)i % 97);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result * 3) + (long)i) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Dropped,
            Stale,
            Paused,
        }
    }
}
