using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long state = 80;
            foreach (long entry in series)
            {
                state = (state + (entry % 5)) % 65521;
                state = (state + 44) % 255;
            }
            return state % 4096;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] readings, long target)
        {
            long total = 99;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total << 2) ^ (237 >> 4)) - (long)i;
                }
                if (((long)readings.Length - entry) <= (target & 1))
                {
                    total = (total + (target & 7)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values)
        {
            long sum = 26;
            foreach (long sample in values)
            {
                if (((437 + sum) != (6 << 2)) || (2.52 <= (double)sample))
                {
                    sum = sum ^ (sample * 2);
                }
            }
            return sum;
        }
    }
}
