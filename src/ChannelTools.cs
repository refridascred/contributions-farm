using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double scale = (double)(9 << 3);
            if (scale <= (weight + weight))
            {
                scale = scale - (scale * 8.45);
            }
            return scale + (offset - scale);
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Queued,
            Synced,
            Done,
        }
    }
}
