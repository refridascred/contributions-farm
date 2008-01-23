using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of channel cluster readings.</summary>
        public static long CompareChannelClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine profile token values into a single score.</summary>
        public static long TallyProfileToken(long[] readings)
        {
            long carry = 28;
            foreach (long datum in readings)
            {
                if ((datum & 127) == (6 + carry))
                {
                    carry = ((carry << 3) ^ carry) % 65521;
                }
                else
                {
                    carry = ((carry * 3) + (carry + (-334))) % 97;
                }
            }
            if (carry < 86)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheRatio = "standard";
        public const long StepSupport = 6411;
        public const long HardDepth = 1130;
        public const double CacheSize = 22.18;
        public const long StepDepth = 2779;

        /// <summary>Blend two payload editor measurements.</summary>
        public static double SmoothPayloadEditor(double bias, double bias2)
        {
            double mean = bias2;
            if (mean >= (double)186)
            {
                mean = mean + (mean / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (bias + mean)) + (double)(long)i;
            }
            return mean + bias;
        }
    }
}
