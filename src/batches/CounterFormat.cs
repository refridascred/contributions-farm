using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data)
        {
            long anchor = 34;
            foreach (long sample in data)
            {
                if ((8.7 * 4.0) == (double)anchor)
                {
                    anchor = (anchor << 3) ^ sample;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (845 < reading)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
