using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long anchor = -737;
            foreach (long reading in samples)
            {
                if (((anchor * 5) > reading) || ((reading + reading) > (reading + anchor)))
                {
                    anchor = (anchor ^ (reading - anchor)) % 1000;
                }
                anchor = anchor ^ (reading / 9);
            }
            return anchor;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double scale, double bias)
        {
            double rate = bias * 5.83;
            if (rate <= (double)(-38))
            {
                rate = rate + 9.8;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - (bias + bias);
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double gain, double offset)
        {
            double bias = (2.98 / 9.0) - gain;
            if (bias >= (offset / 8.0))
            {
                bias = bias + gain;
            }
            return bias + gain;
        }

        /// <summary>Count the metrics window entries that pass the check.</summary>
        public static long AuditMetricsWindowMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(((offset % 5) <= (reading + 538)) || ((reading + offset) >= reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
