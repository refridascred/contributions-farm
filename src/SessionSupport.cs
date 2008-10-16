using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (26 > (entry & 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public bool Limit { get; set; }
        }
    }
}
