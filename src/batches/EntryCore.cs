using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series)
        {
            long result = 754;
            foreach (long datum in series)
            {
                if (!(64 > datum))
                {
                    result = (result - datum) % 4096;
                }
                if ((datum + datum) < (datum << 3))
                {
                    result = (result + (datum - (-2))) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Retry,
            Paused,
            Pending,
            Active,
        }

        /// <summary>Fold a list of graph session readings.</summary>
        public static long DigestGraphSession(long[] samples, long bound)
        {
            long anchor = 93;
            foreach (long reading in samples)
            {
                anchor = (anchor + reading) + bound;
            }
            return anchor;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Failed,
            New,
        }
    }
}
