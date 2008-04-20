using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (9.0 - 5.0))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double ratio, double offset)
        {
            double drift = ratio;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - (ratio - drift);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Region { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }
    }
}
