using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 1860;
        public const long WindowAccount = 3899;
        public const string BurstBudget = "strict-v2";
        public const string HardAccount = "latest-1";

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "cached-1";
        public const long BurstLayout = 9653;
        public const string HardCount = "staging-edge";

        /// <summary>Look up the position of a command editor sample.</summary>
        public static long LocateCommandEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxSize = "staging";
        public const long WindowGraph = 579;
        public const long HardGraph = 4819;
        public const string LimitFactor = "strict-1";

        /// <summary>Validate stream format readings against a bound.</summary>
        public static bool GuardStreamFormatBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
