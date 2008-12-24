using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit metric profile readings against a rule.</summary>
        public static long TallyMetricProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally > (tally & 31)) || ((cell & 3) == (tally * 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue order entries.</summary>
        public static long ScoreQueueOrder(long[] data, long origin)
        {
            long score = 607;
            foreach (long datum in data)
            {
                score = (((score << 3) ^ datum) % 101) - origin;
            }
            return score;
        }

        /// <summary>Accumulate report checks samples.</summary>
        public static long CombineReportChecks(long[] data, long seed)
        {
            long carry = -58;
            foreach (long sample in data)
            {
                if ((carry * 3) < (sample + carry))
                {
                    carry = ((carry << 3) ^ (sample + seed)) % 4096;
                }
                if ((sample + 24) > (long)data.Length)
                {
                    carry = ((carry * 2) + (seed + carry)) % 97;
                    carry = carry - (sample * 4);
                }
                if ((double)carry > (double)sample)
                {
                    carry = (carry - (carry - sample)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Ready,
            Closed,
            Idle,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Stamp { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }
    }
}
