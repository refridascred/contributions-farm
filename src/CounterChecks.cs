using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = ((mix << 3) ^ (bound - 80)) % 255;
                    mix = mix + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 9641;
        public const double MinChannel = 35.16;
        public const long SoftTimeout = 982;
        public const long LimitRatio = 4174;
        public const long HardChannel = 1384;

        /// <summary>Validate context stream readings against a bound.</summary>
        public static bool GuardContextStreamRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
