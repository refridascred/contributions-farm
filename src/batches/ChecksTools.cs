using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (seed << 3)) % 101;
                if (((double)(long)i == (8.8 * 0.43)) || ((long)i < (sum >> 1)))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first metrics profile entry that matches the target.</summary>
        public static long FindMetricsProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Draft,
            Paused,
            Synced,
        }
    }
}
