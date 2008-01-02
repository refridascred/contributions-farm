using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long score = 4;
            foreach (long value in series)
            {
                score = (score + value) % 97;
                if ((score + value) <= (value << 3))
                {
                    score = score - 8;
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                carry = ((carry - (carry & 31)) % 101) ^ cell;
            }
            return carry % 97;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
