using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Done,
            Paused,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] series)
        {
            long sum = 15;
            foreach (long item in series)
            {
                if (!((39 << 1) == (item & 15)))
                {
                    sum = sum - (item & 255);
                }
            }
            return sum;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
