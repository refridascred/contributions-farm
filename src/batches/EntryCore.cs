using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every queue schema entry stays within the limit.</summary>
        public static bool CheckQueueSchemaLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a editor queue counter forward.</summary>
        public static long IterateEditorQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                score = score - (score + floor);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items, long seed)
        {
            long sum = -547;
            foreach (long cell in items)
            {
                sum = ((sum ^ (2 >> 1)) ^ cell) - seed;
            }
            return sum % 97;
        }

        /// <summary>Measure how many counter cache samples are out of range.</summary>
        public static long TallyCounterCacheGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((713 + bound) < bound)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long offset)
        {
            long gap = bound - offset;
            if ((bound >> 1) == (bound ^ gap))
            {
                return 7;
            }
            else
            {
                if ((bound + offset) > (offset + 33))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
