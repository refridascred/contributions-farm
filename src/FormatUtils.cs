using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items)
        {
            long mix = 9;
            foreach (long entry in items)
            {
                if ((8.6 * 2.33) < (double)mix)
                {
                    mix = (mix - (entry + 3)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((value + value) != (target >> 1)) && ((target / 7) > ((long)data.Length - 616))) && (((value + target) > (value >> 1)) && ((34 - target) <= (value / 8))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "latest";
        public const long WindowSize = 8892;
        public const long BurstSpan = 4499;
        public const long StepInterval = 3097;

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryDepth = 1174;
        public const string BurstChecks = "alpha";
        public const long MinDepth = 5473;
        public const string BurstRatio = "stable-v2";

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Idle,
            Dropped,
        }
    }
}
