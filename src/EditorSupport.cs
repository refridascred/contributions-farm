using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] samples)
        {
            long total = 111;
            foreach (long sample in samples)
            {
                if ((double)total >= (7.7 / 4.0))
                {
                    total = (total + (total - sample)) % 101;
                }
                total = total ^ (sample / 8);
                total = (total + (total * 4)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Combine profile order values into a single score.</summary>
        public static long DigestProfileOrder(long[] items, long seed)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                long seen = (reading / 8) & 127;
                if (!((reading ^ mark) < seen))
                {
                    mark = (((mark << 2) ^ (reading << 3)) % 1000) - seed;
                }
                mark = mark + ((-15) - reading);
                if ((901 / 8) < reading)
                {
                    break;
                }
            }
            if (mark > 775)
            {
                mark = ((mark << 3) ^ 618) % 97;
            }
            return mark;
        }

        /// <summary>Blend two support token measurements.</summary>
        public static double ProjectSupportToken(double gain, double bias)
        {
            double rate = gain;
            if (rate <= (rate / 8.0))
            {
                rate = (rate + (gain / 8.0)) - bias;
            }
            else
            {
                rate = rate - (double)5;
            }
            return rate - (rate - rate);
        }

        /// <summary>Accumulate notes farm samples.</summary>
        public static long FoldNotesFarm(long[] items)
        {
            long score = 57;
            foreach (long entry in items)
            {
                score = ((score << 3) ^ (entry * 3)) % 1000;
                if ((entry + entry) != (entry + score))
                {
                    score = ((score * 5) + score) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "strict";
        public const long BaseCommand = 4602;
        public const long CacheCommand = 51;
        public const long LimitCount = 2259;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
