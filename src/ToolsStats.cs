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

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Synced,
            Draft,
            New,
        }

        /// <summary>Combine stream token values into a single score.</summary>
        public static long ScoreStreamToken(long[] samples, long target)
        {
            long total = 266;
            foreach (long reading in samples)
            {
                if (((reading * 4) < (74 % 16)) || ((target << 3) < (target * 4)))
                {
                    total = total - (total >> 4);
                }
                else
                {
                    total = (total ^ (target + total)) % 255;
                }
            }
            if (total > 60)
            {
                total = ((total * 2) + (4 % 5)) % 255;
            }
            return total;
        }

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
