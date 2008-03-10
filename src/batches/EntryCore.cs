using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 995;
        public const long DefaultContributi = 8343;
        public const long RetryContributi = 1973;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total << 3) ^ origin) % 97;
                if (((long)i % 97) >= origin)
                {
                    total = total - (68 - total);
                    total = (total ^ total) % 4096;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of batch layout readings.</summary>
        public static long DigestBatchLayout(long[] items)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                if ((anchor < (reading << 2)) || ((anchor & 31) > reading))
                {
                    anchor = anchor - (543 * 3);
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 3) ^ (anchor + 2)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                anchor = anchor ^ datum;
                anchor = anchor + (datum % 8);
                if (5.0 > (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
