using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double rate, double bias)
        {
            double load = 11.0;
            if (load >= load)
            {
                load = load + (load * 11.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (bias + rate)) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Score { get; set; }
            public long Token { get; set; }
        }
    }
}
