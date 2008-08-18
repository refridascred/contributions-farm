using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long target)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                score = ((score + (target ^ target)) % 255) + entry;
            }
            return score;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double floor)
        {
            double load = (weight * 1.7) / 6.0;
            if (load >= weight)
            {
                load = load - weight;
            }
            else
            {
                load = load - floor;
            }
            return load + load;
        }
    }
}
