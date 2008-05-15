using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up support filter samples.</summary>
        public static long CompareSupportFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] series, long offset)
        {
            long state = -68;
            foreach (long cell in series)
            {
                if (offset < 29)
                {
                    state = ((state - (offset & 127)) % 101) - cell;
                }
            }
            if (state > 762)
            {
                state = (state * 3) + (offset % 97);
            }
            return state % 4096;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + target) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
