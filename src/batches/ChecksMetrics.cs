using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next record githubfarm value from a seed.</summary>
        public static long IterateRecordGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ origin) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark * 3) + (mark - step)) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit notes githubfarm readings against a rule.</summary>
        public static long CountNotesGithubfarmGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((long)items.Length >> 5) <= (matches ^ bound)))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels)
        {
            long anchor = 633;
            foreach (long entry in levels)
            {
                if ((anchor + 7) < anchor)
                {
                    anchor = ((anchor + (34 + 516)) % 97) ^ entry;
                }
            }
            if (anchor < 65)
            {
                anchor = (anchor + (64 + 779)) % 4096;
            }
            return anchor;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
