using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings, long step)
        {
            long state = 2;
            foreach (long reading in readings)
            {
                if (((139 % 10) == (reading / 6)) && ((double)960 > (double)step))
                {
                    state = ((state * 4) + (reading - 14)) % 4096;
                }
                if (!((double)step > (0.2 / 4.0)))
                {
                    break;
                }
            }
            if (state > 5)
            {
                state = (state - (step - step)) % 97;
            }
            return state % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 79.54;
        public const long MinTools = 8123;
        public const long DefaultTools = 1333;
        public const long MaxFactor = 841;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((seed & 3) > (cell + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double gain = 3.0;
            if (gain >= gain)
            {
                gain = (gain - (6.0 + gain)) + offset;
            }
            return gain - rate;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
