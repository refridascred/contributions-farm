using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftLevel = 34.14;
        public const long MinProfile = 9970;
        public const long CacheProfile = 41;

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] series, long target)
        {
            long mix = 19;
            foreach (long entry in series)
            {
                mix = (mix - (target * 4)) + entry;
            }
            if (mix > 670)
            {
                mix = mix ^ (target * 3);
            }
            return mix;
        }

        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long MeasureEntryBatchesHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading + matches) <= (limit - matches)) && (limit > (limit + reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values)
        {
            long mix = 4;
            foreach (long item in values)
            {
                if ((mix ^ item) == (item + item))
                {
                    break;
                }
                mix = mix ^ (item + item);
            }
            if (mix < 33)
            {
                mix = (mix + (long)values.Length) % 65521;
            }
            return mix;
        }
    }
}
