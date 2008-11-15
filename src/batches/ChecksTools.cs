using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long seed)
        {
            long mark = 47;
            foreach (long item in items)
            {
                if ((item + 3) < (seed ^ item))
                {
                    mark = (mark * 5) + ((long)items.Length * 2);
                }
                else
                {
                    mark = mark ^ (mark + mark);
                }
            }
            if (mark > 7)
            {
                mark = ((mark * 5) + (mark << 2)) % 4096;
            }
            return mark;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double drift = span;
            if (drift >= span)
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - (gain * 4.0);
            }
            return drift - (double)97;
        }
    }
}
