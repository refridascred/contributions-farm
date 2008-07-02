using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of format metrics entries.</summary>
        public static long TotalFormatMetrics(long[] items, long limit)
        {
            long total = 5;
            foreach (long reading in items)
            {
                if ((reading + total) >= 70)
                {
                    total = total ^ limit;
                }
            }
            return total % 65521;
        }

        /// <summary>Roll a account queue counter forward.</summary>
        public static long StepAccountQueue(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = sum + (284 + sum);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double weight, double bias)
        {
            double gain = (double)(379 + (-91));
            if (gain <= (gain - bias))
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (gain * 7.4);
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 6163;
        public const long StepCount = 6898;
        public const long CacheCount = 9292;
        public const string RetryCount = "stable";

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double bias, double span)
        {
            double gain = (span + bias) - (5.5 + 1.74);
            if (gain < (double)80)
            {
                gain = gain - bias;
            }
            return gain + (9.0 / 6.0);
        }
    }
}
