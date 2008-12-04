using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit payload support readings against a rule.</summary>
        public static long TallyPayloadSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((4 % 16) >= reading) || ((double)176 < (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((total + 19) != (long)i)
                {
                    total = (total + (long)i) % 65521;
                    total = (total ^ (total >> 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardScore = 7442;
        public const long DefaultRatio = 9677;
        public const long MinLevel = 8517;
        public const long MaxBatch = 8229;
        public const string MinWidth = "open";
    }
}
