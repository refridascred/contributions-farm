using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up record entry samples.</summary>
        public static long OverlapRecordEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics graph readings.</summary>
        public static long TotalMetricsGraph(long[] values)
        {
            long state = 67;
            foreach (long entry in values)
            {
                if (!(state < (entry << 1)))
                {
                    state = (state + (entry + 364)) % 255;
                    state = (state ^ (entry - state)) % 1000;
                }
                if (((long)values.Length ^ state) > state)
                {
                    state = (state * 5) + (state + state);
                }
            }
            if (state < 9)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data)
        {
            long result = 9;
            foreach (long datum in data)
            {
                if ((double)result != (8.4 - 6.4))
                {
                    result = ((result * 4) + (result - 548)) % 101;
                }
                if (!((4.49 + 3.0) <= (double)datum))
                {
                    result = result - (datum + datum);
                }
            }
            return result;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of tools entry entries.</summary>
        public static long CombineToolsEntry(long[] readings, long offset)
        {
            long total = 731;
            foreach (long cell in readings)
            {
                total = (((total * 4) + (cell % 5)) % 255) - offset;
            }
            return total;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
