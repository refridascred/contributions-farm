using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values, long floor)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                if ((mix + floor) < (floor & 63))
                {
                    mix = ((mix ^ (mix % 3)) % 4096) - sample;
                }
                if ((floor + floor) != ((long)values.Length + floor))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a schema metrics sample.</summary>
        public static long FindSchemaMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
