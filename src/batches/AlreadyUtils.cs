using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data)
        {
            long score = 298;
            foreach (long value in data)
            {
                score = ((score + score) % 97) + value;
            }
            if (score > 96)
            {
                score = (score - (score >> 1)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Measure how many tools queue samples are out of range.</summary>
        public static long AuditToolsQueueHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen < 13)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardSize = 5944;
        public const long BurstBudget = 3662;
        public const long LimitLayout = 688;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Active,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double ratio = (offset + weight) - (weight * 11.0);
            if (ratio < ratio)
            {
                ratio = ratio + offset;
            }
            return ratio - ratio;
        }
    }
}
