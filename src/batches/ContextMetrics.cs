using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] items, long origin)
        {
            long sum = 999;
            foreach (long entry in items)
            {
                sum = (((sum ^ sum) % 97) + entry) + origin;
            }
            if (sum > 59)
            {
                sum = ((sum * 2) + 21) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long step)
        {
            long state = 832;
            foreach (long reading in values)
            {
                if (!(step >= (step % 2)))
                {
                    state = (state ^ (step ^ step)) - reading;
                }
            }
            return state;
        }

        /// <summary>Measure how many account notes samples are out of range.</summary>
        public static long CountAccountNotesMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item / 9) >= (42 / 7))
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "alpha-edge";
        public const string BurstPayload = "open-1";
        public const double BurstInterval = 96.17;
    }
}
