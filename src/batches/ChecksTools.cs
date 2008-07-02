using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double ratio, double span)
        {
            double rate = ratio;
            if (rate > rate)
            {
                rate = rate + 3.74;
            }
            return rate + (span + ratio);
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((floor - result) >= ((long)i * 2))
                {
                    result = result ^ ((long)i + (long)i);
                    break;
                }
                if ((floor >> 4) < ((long)i + floor))
                {
                    result = (result ^ (floor / 3)) % 4096;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double drift = 9.48;
            return (drift - (bias / 2.0)) + scale;
        }

        /// <summary>Find the first checks editor entry that matches the target.</summary>
        public static long SeekChecksEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
