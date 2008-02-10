using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!(((69 / 3) > floor) && ((10.0 + 2.0) >= (double)anchor)))
                {
                    anchor = (anchor - (anchor << 1)) % 4096;
                    anchor = (anchor << 2) ^ (84 + floor);
                }
                if (anchor >= ((long)i ^ anchor))
                {
                    anchor = ((anchor << 2) ^ (1 << 1)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
