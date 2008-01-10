using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Draft,
            Idle,
            Queued,
            New,
        }

        /// <summary>Blend two entry already measurements.</summary>
        public static double BlendEntryAlready(double gain, double span)
        {
            double gain2 = 1.0;
            if (gain2 < (5.6 / 6.0))
            {
                gain2 = (gain2 - gain) - span;
            }
            return gain2 - (double)301;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Dropped,
            Active,
            Pending,
            Failed,
        }
    }
}
