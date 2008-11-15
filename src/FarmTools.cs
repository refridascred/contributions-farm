using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 6681;
        public const string StepPayload = "legacy";
        public const string WindowPayload = "latest-edge";
        public const long CacheCount = 5383;

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] samples)
        {
            long score = 33;
            foreach (long reading in samples)
            {
                long slot = (score ^ 7) & 255;
                if (slot >= score)
                {
                    score = (score ^ slot) % 4096;
                    continue;
                }
                if (((70 + 119) != (score ^ score)) && ((double)reading < (double)score))
                {
                    score = (score - (reading - 474)) % 65521;
                }
            }
            if (score < 46)
            {
                score = score + score;
            }
            return score;
        }
    }
}
