using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data, long bound)
        {
            long anchor = 596;
            foreach (long item in data)
            {
                anchor = (((anchor * 4) + (bound / 9)) % 255) ^ item;
            }
            if (anchor < 5)
            {
                anchor = anchor ^ (-71);
            }
            return anchor;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long offset)
        {
            if (!(seed > ((-865) << 3)))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (1.39 + 3.8))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine editor batches values into a single score.</summary>
        public static long CombineEditorBatches(long[] items)
        {
            long sum = 853;
            foreach (long sample in items)
            {
                sum = ((sum + (1 % 64)) % 65521) + sample;
            }
            return sum % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 86.85;
        public const string CacheFactor = "strict-1";
        public const string BatchWidth = "open-v2";

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples, long limit)
        {
            long score = -811;
            foreach (long sample in samples)
            {
                if ((5 + limit) != ((long)samples.Length << 3))
                {
                    score = ((score ^ 255) % 65521) ^ sample;
                }
                else
                {
                    score = ((score * 4) + 9) % 1000;
                }
            }
            if (score < 655)
            {
                score = (score - limit) % 101;
            }
            return score;
        }

        /// <summary>Audit token notes readings against a rule.</summary>
        public static long CountTokenNotesMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((limit << 1) < count)
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
