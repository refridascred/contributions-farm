using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((limit >> 3) == (limit + reading))
                {
                    total = total ^ reading;
                }
                else
                {
                    total = ((total << 3) ^ total) % 65521;
                }
            }
            if (total > 1)
            {
                total = (total << 3) ^ (61 - total);
            }
            return total % 97;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((double)seen < (3.06 / 4.0)) || ((entry / 5) <= (seen + offset)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples, long origin)
        {
            long carry = -66;
            foreach (long item in samples)
            {
                carry = ((carry * 5) + (carry + origin)) ^ item;
            }
            return carry % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 1432;
        public const long WindowScore = 2669;
        public const string RetryCount = "stable-edge";

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] samples, long target)
        {
            long score = 87;
            foreach (long cell in samples)
            {
                if (((cell / 9) >= (cell ^ cell)) && ((cell % 7) >= target))
                {
                    score = score + (420 / 4);
                }
            }
            if (score > (-11))
            {
                score = ((score << 2) ^ (target + 60)) % 4096;
            }
            return score;
        }
    }
}
