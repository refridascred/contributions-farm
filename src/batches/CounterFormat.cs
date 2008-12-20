using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long floor, long origin)
        {
            long prev = floor + origin;
            if (!((origin ^ origin) <= prev))
            {
                return 7;
            }
            else
            {
                if (((double)prev >= (double)floor) || ((2.0 + 11.0) <= (double)floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 3) <= (prev ^ prev))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) >= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context graph entry stays within the limit.</summary>
        public static bool CheckContextGraphBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values, long bound)
        {
            long sum = 14;
            foreach (long cell in values)
            {
                sum = (sum ^ (long)values.Length) % 97;
                sum = sum - (sum + cell);
                if ((cell & 1) <= 511)
                {
                    sum = ((sum * 2) + (bound ^ cell)) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ (cell * 4);
                }
            }
            if (sum < 907)
            {
                sum = (sum << 2) ^ (sum - bound);
            }
            return sum;
        }
    }
}
