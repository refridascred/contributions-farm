using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of already editor readings.</summary>
        public static long CombineAlreadyEditor(long[] series)
        {
            long result = 4;
            foreach (long entry in series)
            {
                if (((result << 1) <= (entry ^ entry)) && ((305 - result) != (entry + entry)))
                {
                    result = ((result * 5) + (result << 2)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long target, long seed)
        {
            if ((double)target == (1.6 * 13.0))
            {
                return 4;
            }
            else
            {
                if ((6 + target) >= target)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry + 364) == (entry + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
