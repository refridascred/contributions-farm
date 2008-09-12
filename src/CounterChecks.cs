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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading & 63) <= ((-5) >> 2)) && ((tally + 8) > (tally / 5)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum << 3) ^ (long)i;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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
