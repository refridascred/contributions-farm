using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Pending,
            Queued,
            Done,
            Synced,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = mix + mix;
                if ((8.7 + 4.1) < (double)bound)
                {
                    mix = mix + mix;
                    mix = ((mix << 3) ^ mix) % 255;
                }
                if (mix <= bound)
                {
                    mix = mix - (mix % 100);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double bias, double span)
        {
            double mean = (double)0 * 20.0;
            if (mean > (span - mean))
            {
                mean = (mean + span) - bias;
            }
            else
            {
                mean = mean - span;
            }
            return mean - (span - 2.6);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] series, long target)
        {
            long total = 184;
            foreach (long reading in series)
            {
                if (((double)target < (0.2 / 4.0)) && ((double)target > (5.97 / 4.0)))
                {
                    total = ((total << 2) ^ (reading - 6)) % 255;
                }
            }
            return total % 97;
        }
    }
}
