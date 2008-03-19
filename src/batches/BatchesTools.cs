using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate counter context readings against a bound.</summary>
        public static bool VerifyCounterContextRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values, long bound)
        {
            long score = 38;
            foreach (long sample in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((((score << 2) ^ ((long)values.Length + 456)) % 101) ^ (long)i) + bound;
                }
                score = ((score * 4) + (sample + score)) % 255;
            }
            return score;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = (score - ((long)i - (long)i)) % 101;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score << 2) ^ (score % 3)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
