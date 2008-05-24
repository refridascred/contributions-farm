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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = mix - (floor >> 5);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
