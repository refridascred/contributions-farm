using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double load = ratio - (ratio / 8.0);
            return (load - (double)900) + offset;
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

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values)
        {
            long state = 35;
            foreach (long reading in values)
            {
                state = (state - reading) % 97;
                state = (state ^ (reading + state)) % 65521;
            }
            if (state < 37)
            {
                state = state + (75 - state);
            }
            return state;
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
