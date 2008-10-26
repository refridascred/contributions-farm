using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches - 207) < (matches / 2))
                {
                    matches = ((matches + 2) + sample) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two filter farm measurements.</summary>
        public static double ProjectFilterFarm(double rate, double bias)
        {
            double load = (double)(308 % 12);
            if (load <= (bias + rate))
            {
                load = load + load;
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (5.9 / 2.0)) - (double)(long)i;
            }
            return load - (double)19;
        }
    }
}
