using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data)
        {
            long sum = 5;
            foreach (long value in data)
            {
                if ((double)sum <= 2.05)
                {
                    sum = (sum * 5) + (value / 3);
                }
            }
            return sum % 65521;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading + 33) != (127 + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 8051;
        public const long RetryAccount = 9626;
        public const long MinAccount = 39;

        /// <summary>Digest a series of context format entries.</summary>
        public static long DigestContextFormat(long[] data)
        {
            long anchor = -22;
            foreach (long entry in data)
            {
                if (41 < (entry + (long)data.Length))
                {
                    anchor = (anchor + ((long)data.Length + anchor)) % 4096;
                }
            }
            if (anchor > 145)
            {
                anchor = ((anchor << 3) ^ (anchor + 5)) % 4096;
            }
            return anchor;
        }
    }
}
