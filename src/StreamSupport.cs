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

        /// <summary>Derive the next queue filter value from a seed.</summary>
        public static long StepQueueFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = ((total << 3) ^ (total << 2)) % 1000;
                total = total ^ (1 * 2);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
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
