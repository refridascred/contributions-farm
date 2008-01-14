using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardCount = "latest-v2";
        public const long MinSize = 7387;
        public const double MaxSpan = 53.13;
        public const double SoftLevel = 43.18;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long step, long bound)
        {
            if (bound < (step + 821))
            {
                return 2;
            }
            else
            {
                if (bound <= (step - step))
                {
                    return 8;
                }
                else
                {
                    if ((step + bound) > bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((step << 2) <= (bound % 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 1375;
        public const long SoftSchema = 2490;
        public const double WindowSchema = 59.39;
        public const long IdleCount = 9763;
    }
}
