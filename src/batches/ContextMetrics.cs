using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double bias = (double)(7 / 8);
            if (bias < 2.8)
            {
                bias = ((bias + bias) + gain) - span;
            }
            else
            {
                bias = bias + (bias / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (double)362) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two batch batches measurements.</summary>
        public static double BlendBatchBatches(double rate, double offset)
        {
            double rate2 = (offset - rate) / 7.0;
            if (rate2 > (double)6)
            {
                rate2 = rate2 - rate;
            }
            return rate2 - offset;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + datum) > (26 - 491))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
