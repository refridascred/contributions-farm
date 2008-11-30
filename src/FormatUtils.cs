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

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "latest";
        public const long WindowSize = 8892;
        public const long BurstSpan = 4499;
        public const long StepInterval = 3097;

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((12.0 / 6.0) > (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel record readings.</summary>
        public static long WeighChannelRecord(long[] data, long offset)
        {
            long result = 653;
            foreach (long entry in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result - entry) % 101) - (long)i;
                }
                if (!((offset + entry) >= (offset / 8)))
                {
                    result = ((result << 2) ^ (result << 1)) % 101;
                }
            }
            return result % 65521;
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
