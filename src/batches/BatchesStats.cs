using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchLevel = 1108;
        public const double WindowOrder = 54.38;
        public const long MaxOrder = 3943;
        public const long SoftRatio = 6248;

        /// <summary>Match up route tools samples.</summary>
        public static long OverlapRouteToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowLevel = 66.44;
        public const string MinSupport = "cached";
        public const long IdleSupport = 6848;
    }
}
