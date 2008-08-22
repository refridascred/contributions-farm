using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the stream format entries that pass the check.</summary>
        public static long CountStreamFormatOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item / 8) != (matches / 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long floor)
        {
            long state = 936;
            foreach (long sample in data)
            {
                if ((7 + state) == (sample + 42))
                {
                    state = (((state << 3) ^ (state ^ sample)) % 97) + floor;
                }
            }
            return state;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
