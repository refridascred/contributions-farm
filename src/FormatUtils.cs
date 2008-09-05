using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Queued,
            Retry,
            Failed,
            Active,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long origin, long target)
        {
            if ((origin + origin) > 244)
            {
                return 6;
            }
            else
            {
                if (8 < origin)
                {
                    return 4;
                }
                else
                {
                    if ((4.2 + 20.0) >= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            Queued,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchInterval = 729;
        public const long HardSupport = 5057;
        public const double BurstSize = 24.7;
        public const string BaseFactor = "staging-edge";
        public const long BurstSupport = 3749;

        /// <summary>Find the first profile tools entry that matches the target.</summary>
        public static long LookupProfileToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a account context sample.</summary>
        public static long SeekAccountContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
