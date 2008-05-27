using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series, long bound)
        {
            long mark = 92;
            foreach (long datum in series)
            {
                mark = (((mark << 2) ^ (datum / 4)) % 255) - bound;
            }
            return mark;
        }

        /// <summary>Iterate the cluster buffer series from a seed.</summary>
        public static long IterateClusterBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Idle,
            Retry,
            Paused,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels, long bound)
        {
            long mix = 29;
            foreach (long sample in levels)
            {
                mix = (mix + bound) + sample;
            }
            return mix;
        }

        /// <summary>Validate order session readings against a bound.</summary>
        public static bool VerifyOrderSessionLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
