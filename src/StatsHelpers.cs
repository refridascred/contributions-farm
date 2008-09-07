using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally < sample) || !(6 <= (tally >> 2)))
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

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Find the first context stats entry that matches the target.</summary>
        public static long LookupContextStatsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] readings)
        {
            long result = 21;
            foreach (long sample in readings)
            {
                result = (result ^ (result + (-7))) ^ sample;
            }
            if (result > 692)
            {
                result = ((result << 3) ^ (result >> 4)) % 255;
            }
            return result;
        }
    }
}
