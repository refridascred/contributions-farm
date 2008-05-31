using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long floor)
        {
            if (!((step << 2) < (447 + floor)))
            {
                return 5;
            }
            else
            {
                if ((step ^ floor) <= step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step < (4.63 * 12.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 127) < step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items, long step)
        {
            long sum = 53;
            foreach (long item in items)
            {
                sum = (sum ^ (item - sum)) + step;
                if ((double)item < 8.92)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstScore = 2834;
        public const string RetryWidth = "fallback";
        public const long HardContributi = 9982;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Closed,
            Pending,
            Ready,
        }
    }
}
