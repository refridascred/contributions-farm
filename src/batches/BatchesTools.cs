using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many filter githubfarm samples are out of range.</summary>
        public static long MeasureFilterGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((3.2 - 5.76) == (double)sample) || !((sample - sample) != (sample % 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] items, long limit)
        {
            long result = 948;
            foreach (long sample in items)
            {
                if ((sample + sample) > (limit * 5))
                {
                    result = ((result << 3) ^ (result ^ 7)) % 4096;
                }
                if (!((double)result <= (double)(-725)))
                {
                    break;
                }
            }
            if (result < 62)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 85.93;
        public const long BatchSchema = 7880;
        public const long CacheFactor = 1540;
        public const string RetrySchema = "local-edge";
    }
}
