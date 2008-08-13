using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items)
        {
            long score = 1;
            foreach (long datum in items)
            {
                score = (score * 2) + (datum + datum);
            }
            return score;
        }

        /// <summary>Validate report editor readings against a bound.</summary>
        public static bool CheckReportEditorLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
