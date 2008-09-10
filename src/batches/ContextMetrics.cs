using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long bound)
        {
            if ((bound < 569) || (bound < (origin % 60)))
            {
                return 5;
            }
            else
            {
                if ((4.9 * 11.0) <= (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSize = 6571;
        public const long DefaultMetrics = 5465;
        public const long DefaultRatio = 1674;

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings, long origin)
        {
            long anchor = 51;
            foreach (long item in readings)
            {
                anchor = (anchor ^ (origin & 255)) % 4096;
                if ((origin <= 49) && (origin >= (origin / 9)))
                {
                    anchor = (anchor - (62 ^ origin)) % 65521;
                    anchor = (anchor * 5) + (anchor + item);
                }
                anchor = anchor + 935;
            }
            if (anchor < 919)
            {
                anchor = anchor ^ origin;
            }
            return anchor;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long state = 790;
            foreach (long entry in readings)
            {
                if (!((state ^ entry) != (entry ^ state)))
                {
                    state = state + (state >> 1);
                }
                state = state ^ (entry + state);
                state = (state * 4) + (entry >> 1);
            }
            return state;
        }
    }
}
