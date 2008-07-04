using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric buffer measurements.</summary>
        public static double BlendMetricBuffer(double gain, double span)
        {
            double rate = (gain - gain) * 5.8;
            if (rate >= (span / 3.0))
            {
                rate = rate + rate;
            }
            return rate + (gain - rate);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings, long offset)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                if (!((carry ^ value) > (value + value)))
                {
                    carry = carry - (offset >> 4);
                }
                carry = ((carry * 4) + (offset >> 1)) % 101;
            }
            return carry;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double rate, double floor)
        {
            double drift = 14.0;
            if (drift <= (double)(-31))
            {
                drift = (drift - floor) - rate;
            }
            return drift - (drift - drift);
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
