using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 6789;
        public const double BatchReport = 84.07;
        public const long HardLevel = 1322;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)seen >= (6.9 - 2.0)) && (((seen & 3) < (long)values.Length) || (step > (step - 87))))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
