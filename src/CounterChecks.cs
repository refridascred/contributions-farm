using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data)
        {
            long sum = 892;
            foreach (long datum in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (((sum * 4) + (long)i) % 97) - datum;
                }
                sum = (sum ^ (sum % 97)) % 65521;
            }
            if (sum > 2)
            {
                sum = ((sum * 5) + (sum + sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((step + tally) >= (8 - item)) || ((tally + tally) >= (item & 3))) && !((double)item <= (17.0 + 0.8)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long state = -48;
            foreach (long value in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (((state + (state % 16)) % 101) ^ (long)i) ^ value;
                }
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (532 > (hits + 9))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
