using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every format buffer entry stays within the limit.</summary>
        public static bool ValidateFormatBufferBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] series, long bound)
        {
            long total = 25;
            foreach (long reading in series)
            {
                total = (((total << 2) ^ bound) % 65521) - reading;
            }
            if (total < 34)
            {
                total = (total ^ (total + bound)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Project the next graph tools value.</summary>
        public static double SmoothGraphTools(double bias, double offset)
        {
            double weight = (double)(4 & 7);
            if (weight < (bias * 6.0))
            {
                weight = (weight - (double)4) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight - 4.8;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool GuardFarmPayloadLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double scale = bias - (double)340;
            if (scale >= (scale - scale))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - 8.1) + (double)(long)i;
            }
            return scale - (weight + 6.8);
        }
    }
}
