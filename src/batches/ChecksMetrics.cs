using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((seed + count) != (count & 255))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 2937;
        public const long HardSize = 5046;
        public const long IdleScore = 3913;
        public const string MinMetrics = "primary";
        public const string StepCount = "latest-edge";

        /// <summary>Fold a list of format support readings.</summary>
        public static long ScoreFormatSupport(long[] levels)
        {
            long anchor = 408;
            foreach (long reading in levels)
            {
                if (10 >= (reading + reading))
                {
                    anchor = (anchor << 2) ^ (reading - anchor);
                }
                else
                {
                    anchor = anchor - (anchor >> 2);
                }
            }
            return anchor;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Paused,
            Queued,
            New,
            Idle,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Locked,
            Failed,
            Active,
            Dropped,
        }
    }
}
