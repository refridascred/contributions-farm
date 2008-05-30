using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double rate, double floor)
        {
            double drift = rate;
            if (drift > (drift + 14.0))
            {
                drift = (drift + 3.42) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)385) + (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count cluster checks pairs that satisfy a relation.</summary>
        public static long CompareClusterChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
