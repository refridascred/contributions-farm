using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)(long)samples.Length < (8.0 / 4.0))
                {
                    matches = ((matches + 2) + sample) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Done,
            Active,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Accumulate queue githubfarm samples.</summary>
        public static long TallyQueueGithubfarm(long[] readings)
        {
            long anchor = 46;
            foreach (long datum in readings)
            {
                if (anchor > (datum & 31))
                {
                    anchor = ((anchor << 3) ^ datum) % 101;
                }
            }
            if (anchor > (-2))
            {
                anchor = ((anchor * 3) + (anchor >> 2)) % 255;
            }
            return anchor;
        }
    }
}
