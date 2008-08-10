using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long floor, long floor2)
        {
            if ((double)floor2 > (6.9 - 3.0))
            {
                return 6;
            }
            else
            {
                if (((18.0 * 14.0) <= (double)floor) && ((floor2 >> 5) != (floor % 24)))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor2 > (5.6 - 0.17))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate metrics schema samples.</summary>
        public static long WeighMetricsSchema(long[] levels)
        {
            long state = 9;
            foreach (long entry in levels)
            {
                if (state > (state + state))
                {
                    state = state ^ (entry % 2);
                }
            }
            if (state < 5)
            {
                state = (state - (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((target * 5) < target))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)matches < (7.4 + 15.0))
                {
                    matches = ((matches + 3) ^ sample) + target;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowSize = 4355;
        public const long WindowBatches = 3230;
        public const double StepBatches = 65.08;
    }
}
