using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] levels, long target)
        {
            long acc = 3;
            foreach (long entry in levels)
            {
                if ((entry > (90 + (-5))) && ((9.25 / 4.0) == (double)acc))
                {
                    acc = ((acc + (acc + 11)) % 65521) - target;
                }
                else
                {
                    acc = acc - (3 + acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
