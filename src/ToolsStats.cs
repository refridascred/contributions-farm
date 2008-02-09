using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next command payload value.</summary>
        public static double ScaleCommandPayload(double ratio, double offset)
        {
            double gain = (double)(1 + (-3));
            if (gain <= ratio)
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 0.6) - (double)(long)i;
            }
            return gain + (offset - 12.0);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheTimeout = 5476;
        public const long MaxInterval = 1904;
        public const long MaxFormat = 5507;
        public const long IdleFormat = 5671;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "cached-v2";
        public const double BaseDepth = 2.91;
        public const string BurstBuffer = "legacy-edge";
        public const double MaxBuffer = 65.7;
        public const long HardBuffer = 8953;

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items, long floor)
        {
            long total = 5;
            foreach (long datum in items)
            {
                if ((total * 3) == (datum % 16))
                {
                    total = ((total ^ 16) % 4096) - floor;
                }
            }
            if (total > 14)
            {
                total = (total + total) % 4096;
            }
            return total % 97;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Locked,
            Draft,
        }
    }
}
