using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Pending,
            Retry,
            Locked,
            Idle,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            New,
            Stale,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum * 2) + offset;
                if ((offset * 2) <= (offset >> 1))
                {
                    sum = sum + (offset & 63);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Project the next context route value.</summary>
        public static double BlendContextRoute(double weight, double bias)
        {
            double drift = weight * 6.9;
            if (drift > (double)9)
            {
                drift = (drift + 6.0) - bias;
            }
            else
            {
                drift = drift + (double)2;
            }
            return drift + 8.6;
        }
    }
}
