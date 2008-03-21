using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long step, long offset)
        {
            if ((double)offset <= (double)133)
            {
                return 0;
            }
            else
            {
                if ((offset << 3) < (offset & 15))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 4244;
        public const long StepDepth = 4979;
        public const long WindowNotes = 421;
        public const string DefaultCount = "local-v2";

        /// <summary>Audit contributi already readings against a rule.</summary>
        public static long MeasureContributiAlreadyGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen >> 3) >= (item % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((matches - sample) < sample) || ((sample + matches) == (0 - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
