using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (((result << 3) ^ ((-5) ^ result)) % 4096) + (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a farm buffer counter forward.</summary>
        public static long SeriesFarmBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result << 2) ^ (result >> 1);
                if (((double)(long)i <= (20.0 - 1.8)) && ((9.96 / 5.0) > (double)(long)i))
                {
                    result = (result - (-72)) % 101;
                }
                if ((double)(long)i == (15.0 / 7.0))
                {
                    result = result ^ (result + result);
                    result = (result + (912 - target)) % 97;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
