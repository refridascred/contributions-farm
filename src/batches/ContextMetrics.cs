using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 83.19;
        public const long BatchFarm = 6851;
        public const string SoftCount = "standard-v2";

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long bound, long step)
        {
            long diff = bound + step;
            if (4.9 >= (double)diff)
            {
                return 8;
            }
            else
            {
                if (!(diff > (diff / 8)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine account route values into a single score.</summary>
        public static long CombineAccountRoute(long[] data)
        {
            long anchor = 33;
            foreach (long value in data)
            {
                if (anchor < (value << 1))
                {
                    anchor = ((anchor << 2) ^ (anchor >> 5)) % 97;
                }
                if (!((double)value <= (8.0 - 0.02)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Queued,
            Retry,
            Failed,
            Synced,
        }
    }
}
