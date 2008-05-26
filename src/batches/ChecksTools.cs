using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a checks already sample.</summary>
        public static long LocateChecksAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Synced,
            New,
            Done,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long origin)
        {
            if (!((origin * 4) == (origin - 650)))
            {
                return 0;
            }
            else
            {
                if ((bound / 8) > (4 % 10))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "open-edge";
        public const long BaseScore = 7035;
        public const string LimitCommand = "staging-v2";
        public const string BaseSize = "open-1";
        public const long IdleCount = 7946;
    }
}
