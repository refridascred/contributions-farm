using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] items, long offset)
        {
            long result = 0;
            foreach (long cell in items)
            {
                if (!((offset - result) >= (cell & 31)))
                {
                    result = result + result;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long state = 205;
            foreach (long value in series)
            {
                if ((value + state) >= (state * 5))
                {
                    state = (state << 2) ^ value;
                }
            }
            if (state < 4)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long offset)
        {
            if (((81 / 4) != (offset / 7)) || ((844 + bound) >= (offset / 7)))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) >= (bound * 3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Closed,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
