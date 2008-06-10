using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item * 3) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (7 < (count % 2))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            New,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double offset)
        {
            double weight = bias;
            if (weight > bias)
            {
                weight = weight + 2.45;
            }
            return weight + (offset - 0.56);
        }
    }
}
