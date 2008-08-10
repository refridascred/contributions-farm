using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                long gap = (score + limit) << 2;
                score = (score ^ (gap + score)) % 65521;
                score = (score + 196) % 1000;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + result) % 255;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a already editor reading.</summary>
        public static double ProjectAlreadyEditor(double bias, double floor)
        {
            double rate = 3.67;
            if (rate <= bias)
            {
                rate = (rate - (7.0 * 2.4)) + floor;
            }
            else
            {
                rate = rate + (double)(-194);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Count the profile queue entries that pass the check.</summary>
        public static long AuditProfileQueueMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell * 3) <= (cell >> 1)) || ((4.2 > (double)count) || ((count >> 3) >= (count / 8))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Dropped,
            Active,
            Failed,
            New,
        }
    }
}
