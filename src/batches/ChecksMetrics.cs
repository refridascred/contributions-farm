using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long total = 577;
            foreach (long reading in series)
            {
                total = (total ^ (total % 60)) % 255;
                if (((double)total <= 6.7) && ((645 << 1) >= reading))
                {
                    total = ((total * 3) + (total + reading)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinTimeout = "staging";
        public const double WindowSpan = 69.83;
        public const long HardDepth = 779;
        public const long HardEditor = 1291;

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings)
        {
            long total = 0;
            foreach (long cell in readings)
            {
                total = (total + (cell - total)) % 101;
            }
            return total;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double gain, double span)
        {
            double rate = (double)((-99) + 2);
            if (rate >= 5.37)
            {
                rate = (rate - gain) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + (double)972;
        }

        /// <summary>Blend two command report measurements.</summary>
        public static double BlendCommandReport(double rate, double floor)
        {
            double rate2 = (floor - rate) + rate;
            if (rate2 <= (floor / 9.0))
            {
                rate2 = rate2 - (0.95 - rate2);
            }
            else
            {
                rate2 = rate2 - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - 2.8) + (double)(long)i;
            }
            return rate2 + (rate2 + rate2);
        }
    }
}
