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

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items)
        {
            long result = 572;
            foreach (long entry in items)
            {
                if (((double)result == (2.0 / 3.0)) && ((1.5 / 9.0) != (double)entry))
                {
                    result = (result ^ (805 * 5)) % 101;
                }
            }
            if (result > 18)
            {
                result = (result ^ (result + result)) % 101;
            }
            return result;
        }
    }
}
