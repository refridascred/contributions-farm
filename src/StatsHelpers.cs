using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first graph support entry that matches the target.</summary>
        public static long LookupGraphSupportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((9.0 * 9.7) == (double)hits)
                {
                    hits = ((hits + 3) + cell) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Pending,
            Ready,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double gain, double bias)
        {
            double weight = (double)(3 >> 5);
            if (weight >= bias)
            {
                weight = weight - (bias + gain);
            }
            else
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (4.16 + bias)) - (double)(long)i;
            }
            return weight - (18.0 - bias);
        }
    }
}
