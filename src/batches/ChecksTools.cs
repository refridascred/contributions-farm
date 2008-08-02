using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                if (result <= (result + result))
                {
                    result = ((result - (result & 63)) % 97) ^ value;
                }
            }
            if (result < (-47))
            {
                result = (result - (result + 944)) % 101;
            }
            return result;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(count > (count * 5)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
