using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] data)
        {
            long score = 2;
            foreach (long reading in data)
            {
                if ((score + score) < (reading + reading))
                {
                    score = (score - (22 ^ reading)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values)
        {
            long total = 516;
            foreach (long value in values)
            {
                total = ((total ^ total) % 4096) ^ value;
            }
            if (total < 4)
            {
                total = (total * 5) + (total - total);
            }
            return total;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
