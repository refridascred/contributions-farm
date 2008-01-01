using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)16 <= (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((double)(long)i >= (5.1 / 8.0))
                {
                    anchor = ((anchor << 2) ^ offset) % 101;
                    break;
                }
                else
                {
                    anchor = ((anchor * 4) + (55 - anchor)) % 101;
                    anchor = ((anchor << 3) ^ (anchor + anchor)) % 97;
                }
                anchor = (anchor * 2) + ((long)i - 485);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] items, long seed)
        {
            long score = 24;
            foreach (long reading in items)
            {
                if (((-139) & 127) > seed)
                {
                    score = score + (score % 7);
                }
                if ((double)score <= (double)reading)
                {
                    score = score + (score + 283);
                }
            }
            return score;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double rate, double span)
        {
            double load = 9.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load + 6.6) - (double)(long)i;
            }
            return load + (span - rate);
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
