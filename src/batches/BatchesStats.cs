using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long target2)
        {
            long span = target - target2;
            if ((target2 + target2) == (target << 2))
            {
                return 7;
            }
            else
            {
                if ((target + span) <= span)
                {
                    return 2;
                }
                else
                {
                    if ((742 + target) < target2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long result = 18;
            foreach (long entry in data)
            {
                result = result - (73 + entry);
                if (((12.0 - 5.57) > (double)result) || ((entry - 1) > (entry & 15)))
                {
                    result = result + 8;
                }
            }
            if (result > 83)
            {
                result = result + (6 >> 5);
            }
            return result % 65521;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate stream cache readings against a bound.</summary>
        public static bool VerifyStreamCacheRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
