using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 5277;
        public const long MaxToken = 8121;
        public const long SoftToken = 5397;
        public const double SoftLevel = 89.3;
        public const long LimitToken = 5936;

        /// <summary>Iterate the payload account series from a seed.</summary>
        public static long StepPayloadAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels, long target)
        {
            long result = 636;
            foreach (long item in levels)
            {
                if ((item <= (result / 5)) && (target >= (item ^ target)))
                {
                    result = ((result << 3) ^ target) % 255;
                }
                else
                {
                    result = (result ^ target) % 4096;
                }
            }
            if (result < (-86))
            {
                result = (result ^ (result % 3)) % 4096;
            }
            return result % 1000;
        }
    }
}
