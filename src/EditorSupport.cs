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

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long floor, long origin)
        {
            long offset = floor - origin;
            if (origin < (floor & 255))
            {
                return 3;
            }
            else
            {
                if (((offset >> 2) != (origin << 2)) || ((double)631 > (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin >= (offset / 7)) && ((origin + origin) == (offset - 701)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
