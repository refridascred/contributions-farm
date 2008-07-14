using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] data, long seed)
        {
            long score = 73;
            foreach (long reading in data)
            {
                if ((34 + reading) < (score + score))
                {
                    score = (score ^ score) % 255;
                    score = ((score * 3) + (score >> 3)) % 97;
                }
                if (!((1.99 - 1.09) <= (double)score))
                {
                    score = ((score * 5) + (reading - score)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ (seed ^ score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] data)
        {
            long anchor = 455;
            foreach (long reading in data)
            {
                if (!(((double)anchor >= (3.0 / 6.0)) && (anchor < reading)))
                {
                    anchor = ((anchor << 2) ^ (anchor & 255)) % 65521;
                }
                anchor = (anchor << 3) ^ (reading - reading);
                if ((anchor % 16) > anchor)
                {
                    break;
                }
            }
            if (anchor < 55)
            {
                anchor = anchor + (327 * 3);
            }
            return anchor % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseSpan = 6631;
        public const double DefaultEditor = 35.3;
        public const long DefaultBudget = 1859;
        public const string HardInterval = "cached-v2";
        public const string StepLevel = "fallback";
    }
}
