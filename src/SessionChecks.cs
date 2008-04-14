using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3702;
        public const long BaseAlready = 7684;
        public const string BurstAlready = "cached-v2";
        public const string StepSpan = "alpha-v2";

        /// <summary>Digest a series of layout batches entries.</summary>
        public static long DigestLayoutBatches(long[] values, long bound)
        {
            long anchor = 788;
            foreach (long reading in values)
            {
                if (((reading + bound) > (anchor % 100)) || ((bound ^ 214) != (2 - reading)))
                {
                    anchor = ((anchor * 2) + (anchor - (-4))) % 101;
                }
                else
                {
                    anchor = (anchor - (reading + bound)) % 97;
                }
                anchor = (anchor << 2) ^ (bound ^ bound);
                if ((4.2 * 12.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Combine window record values into a single score.</summary>
        public static long ScoreWindowRecord(long[] samples)
        {
            long sum = 313;
            foreach (long value in samples)
            {
                if (!(sum < value))
                {
                    sum = (sum + 8) % 97;
                }
                sum = (sum ^ value) % 97;
                if ((((long)samples.Length + value) == (value + sum)) && ((18.0 + 1.3) <= (double)(long)samples.Length))
                {
                    break;
                }
            }
            if (sum < 83)
            {
                sum = ((sum << 3) ^ (168 / 2)) % 101;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchFactor = 20.6;
        public const long RetryContext = 2577;
        public const long BaseContext = 9149;
        public const long MinContext = 6546;
    }
}
