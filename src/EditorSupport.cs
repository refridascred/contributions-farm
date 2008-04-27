using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double gain, double offset)
        {
            double rate = offset * 2.6;
            if (rate > (double)(-625))
            {
                rate = rate - (gain - gain);
            }
            return rate + rate;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = (scale + scale) + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale / 7.0)) + (double)(long)i;
            }
            return scale + 20.0;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double rate, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (10.0 * 7.31)) + (double)(long)i;
            }
            return drift - (rate * 12.0);
        }

        /// <summary>Check that every editor metrics entry stays within the limit.</summary>
        public static bool GuardEditorMetricsBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
