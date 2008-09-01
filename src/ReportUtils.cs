using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            Active,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] data)
        {
            long sum = -59;
            foreach (long datum in data)
            {
                if (!(datum <= (sum + datum)))
                {
                    sum = (sum + (datum ^ datum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Iterate the route profile series from a seed.</summary>
        public static long IterateRouteProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (step << 3)) % 255;
                if ((8 < (step ^ step)) || ((carry + 3) < step))
                {
                    break;
                }
                else
                {
                    carry = (carry * 4) + carry;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 5623;
        public const long DefaultDepth = 3911;
        public const string IdleFactor = "latest-v2";
        public const long HardCount = 9755;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Stale,
            Active,
            Paused,
        }
    }
}
