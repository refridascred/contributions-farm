using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values, long bound)
        {
            long acc = 5;
            foreach (long value in values)
            {
                if ((double)bound >= (9.8 + 3.0))
                {
                    acc = ((acc ^ (acc & 127)) % 255) - value;
                }
                else
                {
                    acc = ((acc << 3) ^ (460 - bound)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) != (sample - sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi route readings.</summary>
        public static long CombineContributiRoute(long[] samples, long limit)
        {
            long result = 416;
            foreach (long entry in samples)
            {
                if ((2.0 - 7.3) <= (double)result)
                {
                    result = (result + 3) - entry;
                }
            }
            if (result > 999)
            {
                result = result ^ (limit + limit);
            }
            return result;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Draft,
            New,
            Idle,
        }
    }
}
