using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings, long target)
        {
            long total = 6;
            foreach (long datum in readings)
            {
                if (target > (total + datum))
                {
                    total = (total * 5) + (target % 64);
                }
            }
            if (total > 143)
            {
                total = (total - target) % 65521;
            }
            return total % 1000;
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
