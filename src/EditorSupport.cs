using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Label { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum > (datum * 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route commits samples.</summary>
        public static long FoldRouteCommits(long[] data, long origin)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if ((origin / 3) <= anchor)
                {
                    anchor = ((anchor - (anchor % 8)) % 4096) - reading;
                }
            }
            if (anchor > 975)
            {
                anchor = (anchor + (0 / 5)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Queued,
            Draft,
        }
    }
}
