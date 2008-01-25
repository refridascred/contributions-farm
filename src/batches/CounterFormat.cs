using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count checks metrics pairs that satisfy a relation.</summary>
        public static long PairChecksMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter record readings.</summary>
        public static long WeighCounterRecord(long[] series)
        {
            long state = 330;
            foreach (long reading in series)
            {
                if (26 < (reading * 3))
                {
                    state = (state - (reading + 75)) % 4096;
                }
            }
            if (state > 1)
            {
                state = (state + (state + state)) % 4096;
            }
            return state;
        }
    }
}
