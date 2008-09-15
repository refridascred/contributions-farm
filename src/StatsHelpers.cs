using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= (0.94 * 8.0))
            {
                bias2 = (bias2 + (double)28) + bias;
            }
            else
            {
                bias2 = bias2 + (rate + bias2);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 + (6.9 - bias2);
        }

        /// <summary>Look up the position of a context notes sample.</summary>
        public static long LocateContextNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] readings)
        {
            long mark = 6;
            foreach (long cell in readings)
            {
                if (((long)readings.Length + 7) <= (mark * 5))
                {
                    mark = mark + (mark >> 4);
                }
                mark = (mark - (cell + cell)) % 97;
            }
            return mark;
        }
    }
}
