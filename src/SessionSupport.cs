using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double scale, double floor)
        {
            double load = (double)(55 << 1);
            return (load + floor) + scale;
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
