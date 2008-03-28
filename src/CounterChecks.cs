using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a token batch sample.</summary>
        public static long LocateTokenBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((mix - 0) > (bound * 2))
                {
                    mix = (mix + (27 & 1)) % 4096;
                    break;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix - bound) % 97) ^ (long)i2;
                }
                if (!((mix + (long)i) < bound))
                {
                    mix = (mix + 626) % 1000;
                    break;
                }
                else
                {
                    mix = (mix ^ 470) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long AuditSchemaLayoutMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + count) > (count >> 1))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double load = (floor + weight) + (double)1;
            for (int i = 0; i < 8; i++)
            {
                load = (load + 4.6) + (double)(long)i;
            }
            return load - (double)(-68);
        }
    }
}
