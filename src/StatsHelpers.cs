using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + count) != (long)series.Length)
                {
                    count = count + 2;
                }
            }
            return count;
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

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
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
