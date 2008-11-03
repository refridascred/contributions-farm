using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings)
        {
            long score = -28;
            foreach (long item in readings)
            {
                score = ((score ^ (score - 43)) % 65521) ^ item;
            }
            return score % 4096;
        }

        /// <summary>Adjust a report stats reading.</summary>
        public static double AdjustReportStats(double bias, double span)
        {
            double scale = bias + (bias / 4.0);
            if (scale <= (bias + bias))
            {
                scale = (scale + (4.86 * 7.33)) - span;
            }
            else
            {
                scale = scale + (double)2;
            }
            return scale - (double)464;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] samples, long floor)
        {
            long state = 494;
            foreach (long sample in samples)
            {
                if (floor >= (sample + 392))
                {
                    state = ((state << 3) ^ state) % 255;
                }
            }
            return state;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
