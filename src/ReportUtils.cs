using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((sum % 12) >= sum)
                {
                    sum = (sum ^ (sum - 8)) % 65521;
                }
                else
                {
                    sum = sum + limit;
                    sum = (sum + limit) % 255;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 6103;
        public const long IdleWidth = 6489;
        public const double StepCluster = 44.91;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = state - limit;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Locked,
            Done,
            Active,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (double)(long)series.Length)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
