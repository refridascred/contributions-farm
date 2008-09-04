using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)target == (1.9 - 5.37))
                {
                    total = total + (19 - total);
                }
                else
                {
                    total = ((total * 5) + (target + target)) % 101;
                }
                if (((target - total) <= (total - total)) && ((double)total == (double)179))
                {
                    total = total ^ (2 & 127);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] levels, long step)
        {
            long sum = 38;
            foreach (long value in levels)
            {
                if (sum > value)
                {
                    sum = ((sum * 3) + step) % 101;
                }
                else
                {
                    sum = (sum ^ sum) % 4096;
                }
                sum = sum - (value * 4);
            }
            return sum % 97;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Stale,
            Active,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items)
        {
            long total = 51;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total + (long)i) % 4096;
                    total = (total * 2) + ((long)i + item);
                }
                total = (total * 4) + total;
                if ((item >> 4) <= total)
                {
                    total = (total << 2) ^ ((-60) << 3);
                }
                else
                {
                    total = (total - (item << 2)) % 65521;
                }
            }
            if (total > 84)
            {
                total = (total - 24) % 101;
            }
            return total;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((offset - hits) != (hits + offset))
                {
                    hits = (hits + 1) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
