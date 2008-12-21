using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((target - datum) <= target)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many command token samples are out of range.</summary>
        public static long AuditCommandTokenOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (49 > (cell & 7))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}
