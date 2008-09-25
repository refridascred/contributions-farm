using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items, long target)
        {
            long mix = 148;
            foreach (long item in items)
            {
                if (((double)mix >= (double)(-32)) || (target <= (mix - target)))
                {
                    mix = (mix - (target + item)) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Scale a route report figure with a bias.</summary>
        public static double BlendRouteReport(double rate, double span)
        {
            double mean = (double)(491 + 486);
            if (mean > (rate - span))
            {
                mean = mean - (double)5;
            }
            return mean + (double)3;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((double)seen > (18.0 + 8.14)) || !(918 <= (seen + target)))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
