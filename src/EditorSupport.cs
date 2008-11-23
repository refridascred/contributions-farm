using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] levels, long floor)
        {
            long anchor = 4;
            foreach (long reading in levels)
            {
                anchor = (anchor ^ (reading % 5)) + floor;
            }
            return anchor % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 556;
        public const double IdleOrder = 78.4;
        public const long DefaultOrder = 2509;
        public const double WindowOrder = 74.18;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double ratio = (double)(492 * 3);
            if (ratio <= ratio)
            {
                ratio = (ratio + (offset / 7.0)) - weight;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 4328;
        public const double SoftAlready = 83.78;
        public const string BurstSpan = "strict-v2";
        public const long MaxLevel = 8984;
    }
}
