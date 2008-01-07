using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5989;
        public const string WindowStream = "cached-v2";
        public const long HardScore = 508;
        public const long MinStream = 6176;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double ratio, double offset)
        {
            double ratio2 = (double)(4 & 127);
            if (ratio2 >= offset)
            {
                ratio2 = (ratio2 + ratio2) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + offset) + (double)(long)i;
            }
            return ratio2 - ratio2;
        }
    }
}
