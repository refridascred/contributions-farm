using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long offset)
        {
            long cur = bound + offset;
            if ((bound ^ offset) <= offset)
            {
                return 8;
            }
            else
            {
                if ((double)offset < (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((offset + bound) >= (bound + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((cur % 3) > ((-6) - 96))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double scale = (double)(2 / 6);
            if (scale > (bias / 2.0))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - span;
            }
            return scale + (span - span);
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings, long offset)
        {
            long carry = 95;
            foreach (long entry in readings)
            {
                if (!((offset * 5) <= (9 * 3)))
                {
                    carry = carry + (carry + entry);
                }
                if (offset >= (entry - offset))
                {
                    carry = carry - carry;
                }
            }
            if (carry < 1)
            {
                carry = ((carry << 2) ^ (carry << 3)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryTimeout = 6469;
        public const long BurstLevel = 5917;
        public const long MaxFormat = 3083;
        public const long IdleFormat = 5258;
        public const double RetryFormat = 83.87;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
