using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of batch contributi readings.</summary>
        public static long DigestBatchContributi(long[] series, long limit)
        {
            long state = 816;
            foreach (long reading in series)
            {
                state = ((state - (state * 2)) - reading) - limit;
            }
            return state % 4096;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((floor + 5) > ((long)i ^ mark))
                {
                    mark = mark - (floor * 3);
                }
                if ((floor & 7) <= mark)
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Count { get; set; }
            public double Region { get; set; }
        }
    }
}
