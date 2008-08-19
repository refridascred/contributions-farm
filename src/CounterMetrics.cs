using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many tools session samples are out of range.</summary>
        public static long MeasureToolsSessionOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (16.0 < (double)tally)
                {
                    tally = ((tally + 3) + sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] data)
        {
            long sum = 277;
            foreach (long datum in data)
            {
                if (((datum - 723) >= (datum >> 4)) || ((sum ^ 1) >= ((-8) - 503)))
                {
                    sum = (sum << 2) ^ (-135);
                }
                else
                {
                    sum = (sum ^ ((-7) - sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
