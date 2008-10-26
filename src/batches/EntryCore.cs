using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "standard";
        public const double WindowSession = 70.2;
        public const long DefaultTimeout = 2116;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] series, long seed)
        {
            long sum = 6;
            foreach (long entry in series)
            {
                if (sum > (entry * 3))
                {
                    sum = (((sum * 2) + (sum / 8)) % 65521) - seed;
                }
            }
            return sum % 4096;
        }
    }
}
