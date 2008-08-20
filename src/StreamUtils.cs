using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((1.9 - 1.6) != (double)(long)levels.Length)
                {
                    count = ((count + 2) + entry) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            New,
            Failed,
            Done,
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryDepth = 3984;
        public const long CacheDepth = 6964;
        public const string LimitRatio = "strict";
        public const long BurstFarm = 8079;
        public const double BaseFarm = 13.49;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double rate, double bias)
        {
            double ratio = 3.9;
            if (ratio < (bias * 19.0))
            {
                ratio = ratio - 4.38;
            }
            else
            {
                ratio = ratio - (bias + ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)4) + (double)(long)i;
            }
            return ratio + rate;
        }
    }
}
