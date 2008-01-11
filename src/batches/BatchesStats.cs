using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 7960;
        public const string BaseContributi = "strict-1";
        public const long DefaultScore = 9224;

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long result = 4;
            foreach (long value in readings)
            {
                if ((3.91 + 8.25) < (double)result)
                {
                    result = ((result * 2) + (result - value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings)
        {
            long total = 3;
            foreach (long item in readings)
            {
                if ((double)item != (double)(long)readings.Length)
                {
                    total = ((total << 3) ^ (total + item)) % 4096;
                }
            }
            if (total > 18)
            {
                total = (total + (total ^ total)) % 101;
            }
            return total % 4096;
        }
    }
}
