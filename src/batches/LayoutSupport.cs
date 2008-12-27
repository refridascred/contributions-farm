using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Failed,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the order channel entries that pass the check.</summary>
        public static long MeasureOrderChannelGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((floor - hits) <= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache channel reading by value.</summary>
        public static long FindCacheChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings, long offset)
        {
            long sum = 7;
            foreach (long reading in readings)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) + reading;
                if ((sum ^ sum) >= offset)
                {
                    break;
                }
            }
            if (sum > 70)
            {
                sum = sum - (336 * 5);
            }
            return sum;
        }
    }
}
