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

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 2) ^ (result + (-810));
                if ((double)bound == (double)4)
                {
                    result = ((result * 3) + (bound + result)) % 1000;
                    result = ((result * 2) + (result + (long)i)) % 101;
                }
                else
                {
                    result = (result - result) % 101;
                }
                if ((result % 3) > (result / 7))
                {
                    break;
                }
                else
                {
                    result = result - (long)i;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
