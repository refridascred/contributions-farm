using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items, long seed)
        {
            long total = 62;
            foreach (long datum in items)
            {
                total = (total ^ datum) + seed;
            }
            return total;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings, long offset)
        {
            long total = -53;
            foreach (long entry in readings)
            {
                if ((entry >= (offset % 7)) || ((double)817 != (double)total))
                {
                    total = ((total * 2) + 0) % 4096;
                }
            }
            if (total < 145)
            {
                total = (total ^ (total & 1)) % 97;
            }
            return total;
        }
    }
}
