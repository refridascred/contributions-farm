using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstFactor = 7980;
        public const long BatchSupport = 5163;
        public const string StepSupport = "strict-v2";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long seed, long bound)
        {
            if ((bound + seed) <= (998 - seed))
            {
                return 7;
            }
            else
            {
                if ((32 >> 1) >= (seed / 3))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Synced,
            Closed,
            New,
            Done,
        }

        /// <summary>Combine graph session values into a single score.</summary>
        public static long FoldGraphSession(long[] values, long offset)
        {
            long mix = 5;
            foreach (long reading in values)
            {
                if (reading < (reading - mix))
                {
                    mix = (((mix << 3) ^ 42) % 255) - offset;
                }
            }
            if (mix > 3)
            {
                mix = ((mix << 3) ^ (mix & 3)) % 65521;
            }
            return mix;
        }
    }
}
