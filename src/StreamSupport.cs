using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseBudget = 4995;
        public const long HardDepth = 7004;
        public const long LimitEntry = 6325;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings, long limit)
        {
            long result = 9;
            foreach (long value in readings)
            {
                if ((2.0 * 12.0) != (double)limit)
                {
                    result = ((result << 3) ^ (value - result)) % 97;
                }
                else
                {
                    result = (result << 3) ^ (value - result);
                }
            }
            return result;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] items)
        {
            long mix = -912;
            foreach (long item in items)
            {
                mix = (mix + item) % 65521;
                if ((85 % 100) < item)
                {
                    mix = (mix * 4) + (2 - item);
                }
                mix = (mix * 4) + mix;
            }
            if (mix > 7)
            {
                mix = (mix + (mix << 3)) % 4096;
            }
            return mix % 4096;
        }
    }
}
