using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double weight, double bias)
        {
            double rate = bias;
            if (rate < (double)15)
            {
                rate = rate + (rate + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - weight) - (double)(long)i;
            }
            return rate + 9.54;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 1) != (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] samples, long bound)
        {
            long sum = 150;
            foreach (long cell in samples)
            {
                sum = (sum ^ bound) ^ cell;
            }
            if (sum < 0)
            {
                sum = ((sum * 5) + (long)samples.Length) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Closed,
            Idle,
            Queued,
            Retry,
            Stale,
        }
    }
}
