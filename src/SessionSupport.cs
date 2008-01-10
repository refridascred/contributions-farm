using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of buffer payload readings.</summary>
        public static long MatchBufferPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] samples, long step)
        {
            long mark = 86;
            foreach (long reading in samples)
            {
                mark = (((mark * 4) + (mark << 2)) ^ reading) - step;
            }
            if (mark > (-9))
            {
                mark = ((mark * 3) + mark) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
