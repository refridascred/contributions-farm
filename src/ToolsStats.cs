using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryWidth = 8293;
        public const long MinRatio = 1174;
        public const string RetryBudget = "open-edge";

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ result) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Dropped,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long CombineLayoutAlready(long[] data, long bound)
        {
            long mix = 276;
            foreach (long reading in data)
            {
                if ((1.1 - 9.9) < (double)reading)
                {
                    mix = (((mix * 2) + (reading * 5)) % 255) - bound;
                }
            }
            if (mix > (-198))
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Retry,
            Idle,
            Paused,
        }
    }
}
