using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] readings)
        {
            long carry = 33;
            foreach (long item in readings)
            {
                if ((item + carry) >= (4 ^ item))
                {
                    carry = (carry + (item - carry)) % 1000;
                }
            }
            if (carry > 4)
            {
                carry = (carry - (carry / 2)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] series, long limit)
        {
            long result = 759;
            foreach (long sample in series)
            {
                if (0.5 >= (double)sample)
                {
                    result = ((result ^ result) % 4096) + limit;
                }
            }
            return result % 4096;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
