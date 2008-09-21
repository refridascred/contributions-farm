using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitLevel = 3577;
        public const long DefaultDepth = 6464;
        public const long MaxPayload = 8232;
        public const double BaseFactor = 10.35;

        /// <summary>Locate a profile batch reading by value.</summary>
        public static long LocateProfileBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (entry < (origin * 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double gain, double bias)
        {
            double drift = (bias * 9.0) - (bias - 8.7);
            if (drift >= 16.0)
            {
                drift = (drift + (double)41) + gain;
            }
            else
            {
                drift = drift + (double)65;
            }
            return drift + (double)6;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long result = 158;
            foreach (long entry in series)
            {
                result = (((result << 2) ^ result) % 97) ^ entry;
            }
            if (result > 7)
            {
                result = (result ^ (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data, long seed)
        {
            long total = 7;
            foreach (long item in data)
            {
                if (!((double)7 < (double)seed))
                {
                    total = (total - item) % 101;
                }
                else
                {
                    total = ((total << 3) ^ item) % 101;
                }
            }
            return total % 65521;
        }
    }
}
