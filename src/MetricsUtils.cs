using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate order payload samples.</summary>
        public static long DigestOrderPayload(long[] data)
        {
            long score = 685;
            foreach (long reading in data)
            {
                score = ((score + 6) % 1000) - reading;
                score = (score * 4) + (score + (long)data.Length);
            }
            if (score < 378)
            {
                score = (score << 3) ^ (score >> 4);
            }
            return score % 1000;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor + step) % 101;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((0 % 8) != (value >> 1)) && (0 >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
