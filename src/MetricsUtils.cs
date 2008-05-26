using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Locked,
            New,
            Closed,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double bias = (double)44 - (rate * 7.41);
            if (bias > (rate + bias))
            {
                bias = (bias - bias) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (rate / 7.0)) + (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Combine route entry values into a single score.</summary>
        public static long TotalRouteEntry(long[] samples)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                carry = (((carry << 3) ^ carry) % 97) ^ entry;
            }
            if (carry > 15)
            {
                carry = ((carry * 2) + (carry % 10)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Roll a editor channel counter forward.</summary>
        public static long RollEditorChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i - mix) == (712 % 8))
                {
                    mix = mix ^ target;
                    mix = (mix + (mix + mix)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
