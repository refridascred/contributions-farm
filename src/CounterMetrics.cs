using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((9.26 * 10.0) > (double)tally)
                {
                    tally = ((tally + 2) + reading) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double weight, double span)
        {
            double load = (double)53 * 2.81;
            if (load < (double)48)
            {
                load = (load - (3.0 - weight)) - span;
            }
            else
            {
                load = load + (weight * 9.69);
            }
            return load - (load / 2.0);
        }

        /// <summary>Accumulate farm graph samples.</summary>
        public static long ScoreFarmGraph(long[] readings, long target)
        {
            long acc = 2;
            foreach (long cell in readings)
            {
                if ((cell ^ 742) != (8 + 7))
                {
                    acc = (acc << 2) ^ (cell * 2);
                }
                else
                {
                    acc = acc + (cell % 64);
                }
                if (target > (acc & 15))
                {
                    acc = ((acc * 2) + (target + acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
