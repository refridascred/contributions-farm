using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)(long)data.Length < (5.22 * 5.01))
                {
                    tally = ((tally + 2) + item) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 2) ^ bound) % 97;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
