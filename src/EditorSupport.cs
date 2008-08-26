using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the entry farm series from a seed.</summary>
        public static long RollEntryFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor ^ 925) + (long)i2;
                }
                if (((long)i + anchor) > offset)
                {
                    anchor = anchor + offset;
                    break;
                }
                else
                {
                    anchor = (anchor * 2) + 9;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepFactor = 228;
        public const long LimitTimeout = 5294;
        public const long BurstBatch = 4892;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Locked,
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstSize = 4662;
        public const long SoftGithubfarm = 4978;
        public const long HardDepth = 6955;
        public const long IdleTimeout = 5245;

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series)
        {
            long anchor = 779;
            foreach (long cell in series)
            {
                anchor = ((anchor + (anchor + anchor)) % 97) - cell;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultLevel = 3789;
        public const double BatchFarm = 14.87;
        public const long DefaultFarm = 7117;
        public const long HardCount = 6231;
        public const double BaseFarm = 10.82;
    }
}
