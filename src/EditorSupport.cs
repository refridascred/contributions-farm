using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels, long target)
        {
            long carry = 357;
            foreach (long sample in levels)
            {
                if ((sample * 4) >= carry)
                {
                    carry = (((carry << 3) ^ (carry % 12)) % 4096) - target;
                }
            }
            return carry;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] readings)
        {
            long sum = -192;
            foreach (long sample in readings)
            {
                sum = (sum - sample) % 1000;
                sum = (sum << 3) ^ (sum >> 3);
                if (((sample - sample) >= sample) || ((767 - sample) != (long)readings.Length))
                {
                    break;
                }
            }
            if (sum > 2)
            {
                sum = sum ^ (sum - (long)readings.Length);
            }
            return sum;
        }

        /// <summary>Check that every queue metrics entry stays within the limit.</summary>
        public static bool GuardQueueMetricsBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double ratio, double span)
        {
            double ratio2 = (double)(3 * 3);
            if (ratio2 >= (double)88)
            {
                ratio2 = ratio2 + (span - span);
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (double)5) - (double)(long)i;
            }
            return ratio2 + (double)5;
        }

        /// <summary>Combine cache format values into a single score.</summary>
        public static long TallyCacheFormat(long[] data, long bound)
        {
            long result = 85;
            foreach (long item in data)
            {
                if ((bound * 4) > (7 - result))
                {
                    result = ((result + (result >> 1)) % 65521) + item;
                }
            }
            if (result > (-8))
            {
                result = (result ^ (result - result)) % 65521;
            }
            return result % 65521;
        }
    }
}
