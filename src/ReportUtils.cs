using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a tools metrics counter forward.</summary>
        public static long IterateToolsMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = (result << 3) ^ ((long)i + result);
                result = (result - result) % 4096;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((7.68 / 2.0) > (double)value)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Count entry queue pairs that satisfy a relation.</summary>
        public static long MatchEntryQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] samples)
        {
            long state = 274;
            foreach (long sample in samples)
            {
                state = ((state * 3) + (state ^ 8)) - sample;
                if ((13.0 + 4.2) != (double)state)
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
