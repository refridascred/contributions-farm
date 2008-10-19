using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples, long step)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                mix = ((mix ^ (entry ^ entry)) % 101) + step;
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of already batches entries.</summary>
        public static long TotalAlreadyBatches(long[] data, long origin)
        {
            long total = 5;
            foreach (long entry in data)
            {
                if ((entry > (total + total)) || ((double)origin == (8.27 + 4.0)))
                {
                    total = ((total << 3) ^ (total % 12)) % 4096;
                }
                if ((total / 9) <= (total * 4))
                {
                    total = ((total * 5) + (entry >> 1)) % 65521;
                    continue;
                }
                total = ((total * 5) + (entry & 3)) % 101;
            }
            return total;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
