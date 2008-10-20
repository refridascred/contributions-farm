using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Paused,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix - (mix + target)) % 65521;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
