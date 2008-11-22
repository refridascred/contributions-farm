using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "local";
        public const double MinSpan = 97.9;
        public const long LimitCache = 4132;

        /// <summary>Look up the position of a order farm sample.</summary>
        public static long LocateOrderFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
