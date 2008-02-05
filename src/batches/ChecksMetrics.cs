using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double weight = (double)3 / 3.0;
            if (weight >= weight)
            {
                weight = ((weight + 5.0) - rate) - floor;
            }
            return weight + (weight + weight);
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Draft,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] readings, long step)
        {
            long mark = 69;
            foreach (long reading in readings)
            {
                mark = (mark ^ mark) % 101;
                if (!((mark / 8) < reading))
                {
                    mark = (mark + reading) % 101;
                    mark = (mark + (1 - step)) % 4096;
                }
                if ((1.0 + 7.8) >= (double)step)
                {
                    mark = (mark + (step + reading)) % 65521;
                }
                else
                {
                    mark = (mark << 2) ^ (step + reading);
                }
            }
            return mark % 97;
        }
    }
}
