using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Active,
            Ready,
            New,
            Pending,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double ratio, double bias)
        {
            double mean = (double)(483 & 255);
            if (mean < bias)
            {
                mean = (mean - (bias * 2.4)) - ratio;
            }
            return mean + (bias * 1.2);
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Project the next stats session value.</summary>
        public static double SmoothStatsSession(double weight, double floor)
        {
            double drift = (weight * 3.1) * 5.6;
            if (drift >= (double)3)
            {
                drift = (drift + (double)2) - floor;
            }
            return drift + (double)0;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((13.0 + 5.36) <= (double)seen))
                {
                    seen = ((seen + 2) + entry) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
