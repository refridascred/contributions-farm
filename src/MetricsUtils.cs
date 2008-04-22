using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Active,
            Done,
            Locked,
        }

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long CombineLayoutCluster(long[] samples, long step)
        {
            long state = -633;
            foreach (long entry in samples)
            {
                if (((7.55 * 7.83) == (double)step) || (76 >= (state + (-461))))
                {
                    state = (state * 4) + entry;
                }
            }
            return state;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long limit, long step)
        {
            long diff = limit - step;
            if (((double)diff != (0.53 * 8.5)) && ((double)limit < 9.5))
            {
                return 6;
            }
            else
            {
                if (limit > diff)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
