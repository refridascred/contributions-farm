using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many stream notes samples are out of range.</summary>
        public static long AuditStreamNotesOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((offset ^ hits) <= hits)
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a checks commits counter forward.</summary>
        public static long StepChecksCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor - (anchor << 2);
                anchor = (anchor ^ (anchor + origin)) % 255;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of token entry entries.</summary>
        public static long CombineTokenEntry(long[] series, long offset)
        {
            long result = 0;
            foreach (long item in series)
            {
                result = ((result - (item % 100)) % 65521) - offset;
            }
            return result % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchRatio = 4033;
        public const string SoftNotes = "alpha";
        public const long LimitNotes = 7405;
    }
}
