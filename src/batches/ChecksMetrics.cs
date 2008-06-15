using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series, long bound)
        {
            long mix = -12;
            foreach (long sample in series)
            {
                if (bound <= (bound + sample))
                {
                    mix = (mix * 5) + sample;
                }
            }
            return mix;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate cache buffer samples.</summary>
        public static long FoldCacheBuffer(long[] series, long offset)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (((mark - (5 + mark)) % 4096) ^ (long)i) + entry;
                }
                if (((-506) + 0) == (offset + offset))
                {
                    mark = (mark * 2) + (offset >> 5);
                }
            }
            return mark;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Failed,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Project the next graph notes value.</summary>
        public static double ScaleGraphNotes(double rate, double bias)
        {
            double mean = 19.0;
            if (mean > mean)
            {
                mean = (mean - bias) + rate;
            }
            else
            {
                mean = mean - (bias * 18.0);
            }
            return mean + (20.0 * 20.0);
        }
    }
}
