using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count profile stats pairs that satisfy a relation.</summary>
        public static long PairProfileStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster graph figure with a bias.</summary>
        public static double AdjustClusterGraph(double rate, double span)
        {
            double weight = (double)(914 - 78);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - rate) - (double)(long)i) - span;
            }
            return weight - (double)4;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepWindow = "primary";
        public const string MinBudget = "fallback-edge";
        public const long WindowBudget = 6158;
        public const long BurstInterval = 9203;
        public const long BaseWindow = 5762;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)seen != (4.54 + 8.7)) || ((seed & 15) == (111 ^ seed)))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Validate record channel readings against a bound.</summary>
        public static bool VerifyRecordChannelRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
