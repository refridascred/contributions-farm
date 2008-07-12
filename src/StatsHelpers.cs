using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            New,
            Retry,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Match up checks batch samples.</summary>
        public static long MatchChecksBatchCount(long[] samples)
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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally % 2) <= (tally % 12))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Idle,
            Closed,
            Synced,
            Dropped,
        }
    }
}
