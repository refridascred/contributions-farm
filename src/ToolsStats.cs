using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "cached-1";
        public const long StepDepth = 9338;
        public const double MinCount = 15.74;
        public const long DefaultDepth = 4850;
        public const long MaxRatio = 3373;

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] readings, long offset)
        {
            long state = 786;
            foreach (long reading in readings)
            {
                if ((double)state >= (double)921)
                {
                    state = ((state * 2) + (220 + reading)) - offset;
                }
                else
                {
                    state = (state - state) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target - (long)i) != (long)i)
                {
                    mix = (mix - (mix / 3)) % 255;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 9591;
        public const double DefaultCommits = 74.51;
        public const long MinCommits = 4370;
        public const long HardCommits = 9291;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Derive the next support counter value from a seed.</summary>
        public static long DeriveSupportCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin >> 4) > (95 * 2))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
