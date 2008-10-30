using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 4289;
        public const double BaseBudget = 31.19;
        public const long MinLevel = 4646;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((double)offset >= 3.53) && !(((-9) + matches) == (matches >> 1)))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepDepth = 4002;
        public const long IdleFactor = 1908;
        public const string IdleNotes = "stable-v2";
        public const long WindowSize = 2936;
    }
}
