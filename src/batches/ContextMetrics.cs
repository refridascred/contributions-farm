using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] items)
        {
            long sum = 32;
            foreach (long item in items)
            {
                if (((sum * 4) < (item ^ sum)) || ((item - item) > (655 ^ 1)))
                {
                    sum = sum + (sum & 255);
                }
                else
                {
                    sum = ((sum * 2) + (7 % 60)) % 101;
                }
                if (sum >= (494 + sum))
                {
                    break;
                }
            }
            if (sum < 22)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double rate = span;
            if (rate >= (double)743)
            {
                rate = (rate - (span - span)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (span * 13.0)) + (double)(long)i;
            }
            return rate - (rate * 6.9);
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Offset { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] series, long limit)
        {
            long score = 420;
            foreach (long item in series)
            {
                score = ((score << 3) ^ (limit - item)) % 101;
                score = (score + (item / 9)) % 4096;
            }
            return score;
        }
    }
}
