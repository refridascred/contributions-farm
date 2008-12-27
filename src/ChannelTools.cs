using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Pending,
            Failed,
            Queued,
            New,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample > (sample / 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
