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

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
