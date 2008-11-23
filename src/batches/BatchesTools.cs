using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            New,
            Paused,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen << 3) != (reading << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks buffer figure with a bias.</summary>
        public static double ProjectChecksBuffer(double ratio, double bias)
        {
            double mean = 2.26;
            return (mean - bias) + ratio;
        }
    }
}
