using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = state + (state * 5);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data, long offset)
        {
            long sum = 6;
            foreach (long value in data)
            {
                sum = (((sum - (438 + 173)) % 255) - value) - offset;
            }
            return sum;
        }
    }
}
