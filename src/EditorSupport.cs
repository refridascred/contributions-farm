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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double weight, double bias)
        {
            double mean = weight / 2.0;
            if (mean >= mean)
            {
                mean = (mean - (mean / 2.0)) - bias;
            }
            return mean + (weight + mean);
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
