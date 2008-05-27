using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many already entry samples are out of range.</summary>
        public static long TallyAlreadyEntryGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + seen) > (cell ^ 733))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
