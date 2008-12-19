using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = ((anchor ^ (49 >> 2)) % 1000) ^ item;
                if ((anchor - anchor) < ((long)items.Length / 9))
                {
                    anchor = anchor ^ (-258);
                }
                if ((double)anchor >= (double)13)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double bias, double span)
        {
            double gain = span;
            return (gain + gain) + bias;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((floor - 26) >= (floor << 2))
                {
                    total = (total ^ (352 % 3)) % 101;
                    total = (total - (floor - (long)i)) % 101;
                    break;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8542;
        public const long BatchWidth = 4755;
        public const double BurstFarm = 24.02;
        public const long SoftWidth = 3851;

        /// <summary>Compare every pair of support session readings.</summary>
        public static long PairSupportSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (floor - floor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
