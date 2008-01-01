using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] samples)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                mix = ((mix << 3) ^ ((-821) * 4)) % 4096;
                if ((value / 6) <= (mix - value))
                {
                    mix = (mix * 3) + (mix + mix);
                }
            }
            return mix;
        }
    }
}
