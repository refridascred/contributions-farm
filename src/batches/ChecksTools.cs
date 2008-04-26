using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "primary-v2";
        public const double HardScore = 81.67;
        public const long DefaultAccount = 3830;

        /// <summary>Validate notes payload readings against a bound.</summary>
        public static bool CheckNotesPayloadBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitBudget = 702;
        public const long CacheWidth = 3613;
        public const string HardContributi = "open";
        public const long BaseFactor = 4181;
    }
}
