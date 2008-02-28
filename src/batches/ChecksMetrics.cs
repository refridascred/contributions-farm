using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultInterval = 888;
        public const long StepScore = 2561;
        public const string BurstPayload = "staging";
        public const long WindowRatio = 7715;

        /// <summary>Match up entry session samples.</summary>
        public static long MatchEntrySessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Pending,
            Ready,
            New,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels, long origin)
        {
            long acc = 682;
            foreach (long value in levels)
            {
                if ((origin - (long)levels.Length) <= (origin << 2))
                {
                    acc = acc ^ value;
                }
                else
                {
                    acc = (acc << 2) ^ (value ^ acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
