using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 5023;
        public const double DefaultRoute = 32.0;
        public const string MaxRoute = "standard-1";
        public const long MinSize = 6289;

        /// <summary>Measure how many batches channel samples are out of range.</summary>
        public static long AuditBatchesChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen < (double)910)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
