using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long offset)
        {
            long step = floor + offset;
            if ((step & 255) > (offset / 3))
            {
                return 5;
            }
            else
            {
                if ((230 - step) >= (offset >> 5))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultInterval = 3978;
        public const long RetryTools = 9756;
        public const string BurstInterval = "cached";
        public const long CacheTools = 3326;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the queue format series from a seed.</summary>
        public static long DeriveQueueFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((mix - floor) == (mix / 6))
                {
                    mix = (mix ^ (mix - floor)) % 101;
                    mix = (mix ^ floor) % 255;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
