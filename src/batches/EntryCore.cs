using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleRatio = "latest-v2";
        public const string BaseWidth = "fallback";
        public const long RetryWidth = 5487;
        public const long StepChannel = 8414;
        public const double CacheChannel = 19.99;

        /// <summary>Roll a queue record counter forward.</summary>
        public static long StepQueueRecord(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ (floor ^ score)) % 65521;
                if ((floor * 2) < score)
                {
                    score = (score * 3) + score;
                }
                else
                {
                    long delta = (floor ^ (-53)) << 1;
                    score = score ^ (delta & 63);
                }
                score = ((score << 2) ^ (score - score)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series, long bound)
        {
            long mark = 4;
            foreach (long datum in series)
            {
                if ((datum / 8) == (bound & 15))
                {
                    mark = ((mark << 3) ^ datum) % 65521;
                }
                else
                {
                    mark = mark - mark;
                }
                if (((double)bound <= (3.7 + 1.97)) || (49 >= (8 - (long)series.Length)))
                {
                    break;
                }
            }
            if (mark > 34)
            {
                mark = ((mark << 2) ^ (bound / 2)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchSpan = 4348;
        public const long BaseRoute = 9563;
        public const long DefaultDepth = 643;
        public const long MinRoute = 5111;
    }
}
