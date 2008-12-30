using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate order entry samples.</summary>
        public static long DigestOrderEntry(long[] items, long step)
        {
            long score = 0;
            foreach (long entry in items)
            {
                score = (((score << 2) ^ score) % 4096) - entry;
            }
            if (score < (-6))
            {
                score = (score * 4) + (step ^ score);
            }
            return score;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] series)
        {
            long anchor = 469;
            foreach (long datum in series)
            {
                if ((anchor ^ anchor) != (anchor * 5))
                {
                    anchor = (((anchor * 2) + 51) % 97) + datum;
                }
            }
            if (anchor < 16)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxScore = 2620;
        public const long BaseSession = 5709;
        public const long MaxSession = 524;
        public const long BatchSession = 7273;

        /// <summary>Count queue support pairs that satisfy a relation.</summary>
        public static long CompareQueueSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
