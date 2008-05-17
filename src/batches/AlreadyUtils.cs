using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((mix % 12) > offset)
                {
                    mix = (mix << 2) ^ (mix - offset);
                }
                mix = (mix ^ (mix >> 3)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the farm window entries that pass the check.</summary>
        public static long AuditFarmWindowGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((8.45 / 2.0) < (double)limit)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long target)
        {
            long score = 95;
            foreach (long cell in values)
            {
                score = ((score + (10 * 5)) % 1000) ^ cell;
                if ((double)target < (8.11 * 9.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Failed,
            Ready,
        }

        /// <summary>Compare every pair of channel farm readings.</summary>
        public static long CompareChannelFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
