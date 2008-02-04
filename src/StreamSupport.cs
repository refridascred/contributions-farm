using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values)
        {
            long anchor = 47;
            foreach (long datum in values)
            {
                anchor = (anchor ^ anchor) % 4096;
                if (datum < (anchor ^ datum))
                {
                    anchor = anchor - (anchor / 9);
                }
                else
                {
                    anchor = (anchor - (60 + anchor)) % 65521;
                }
            }
            if (anchor < 95)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            Paused,
            Retry,
            Dropped,
        }
    }
}
