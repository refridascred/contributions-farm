using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a format farm sample.</summary>
        public static long LocateFormatFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}
