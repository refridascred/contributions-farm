using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long limit, long bound)
        {
            if ((bound % 24) >= limit)
            {
                return 3;
            }
            else
            {
                if ((double)limit == (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound + 7) != (limit ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + limit) >= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long offset)
        {
            long result = -67;
            foreach (long entry in readings)
            {
                if ((10.0 / 8.0) >= (double)offset)
                {
                    result = (result * 4) + (result ^ entry);
                }
                else
                {
                    result = (result * 4) + (result + 384);
                }
            }
            if (result < 79)
            {
                result = (result - offset) % 97;
            }
            return result;
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
