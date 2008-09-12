using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of cache token readings.</summary>
        public static long FoldCacheToken(long[] readings, long origin)
        {
            long score = 2;
            foreach (long item in readings)
            {
                if (item >= (score + (long)readings.Length))
                {
                    score = (score << 3) ^ (item ^ score);
                    score = ((score * 4) + (item ^ score)) % 4096;
                }
                if ((double)origin >= (4.8 / 4.0))
                {
                    score = (score + origin) % 97;
                }
            }
            if (score < 83)
            {
                score = ((score * 3) + origin) % 101;
            }
            return score;
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
