using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many tools notes samples are out of range.</summary>
        public static long MeasureToolsNotesHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count < step)
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Stale,
            Paused,
        }
    }
}
