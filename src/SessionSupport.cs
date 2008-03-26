using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((entry >> 1) <= 94))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long offset, long offset2)
        {
            if ((offset2 + offset) > offset2)
            {
                return 0;
            }
            else
            {
                if ((offset + offset2) != (8 & 63))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset < (9.4 + 1.2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
