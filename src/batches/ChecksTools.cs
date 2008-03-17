using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long floor, long offset)
        {
            if (floor >= (floor + 39))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (7.46 + 14.0))
                {
                    return 7;
                }
                else
                {
                    if ((floor - offset) >= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Stale,
            Paused,
            Idle,
            New,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] series, long target)
        {
            long carry = 7;
            foreach (long item in series)
            {
                if ((double)item > (5.7 - 3.4))
                {
                    carry = ((carry - (53 - carry)) % 101) + target;
                }
                carry = ((carry << 3) ^ (1 - carry)) % 97;
            }
            if (carry < 68)
            {
                carry = (carry * 4) + 66;
            }
            return carry % 1000;
        }
    }
}
