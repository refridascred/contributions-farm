using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Done,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSize = 1899;
        public const double WindowFactor = 79.1;
        public const long MinLevel = 6310;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum >> 2) == ((long)series.Length << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
