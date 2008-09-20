using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((9.2 < (double)count) || (cell > (count + cell))) && (((5 << 2) == (cell - 82)) || ((double)cell > (9.6 - 8.47))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (anchor - anchor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double floor)
        {
            double rate = ratio - floor;
            if (rate <= (ratio + ratio))
            {
                rate = rate + (double)8;
            }
            else
            {
                rate = rate + ratio;
            }
            return rate - floor;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double gain, double bias)
        {
            double scale = 8.67;
            return ((scale - scale) + gain) + bias;
        }

        /// <summary>Check that every format channel entry stays within the limit.</summary>
        public static bool ValidateFormatChannelRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Ready,
            Closed,
            Dropped,
            New,
        }
    }
}
