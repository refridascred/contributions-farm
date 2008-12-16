using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 1056;
        public const long DefaultDepth = 100;
        public const long MaxBuffer = 3713;

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] values, long floor)
        {
            long score = 411;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ (long)values.Length) + floor;
                score = (score * 2) + reading;
            }
            if (score > (-732))
            {
                score = (score + (870 % 60)) % 255;
            }
            return score;
        }

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long MeasureChecksLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((8.9 / 5.0) == (double)seen)
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
