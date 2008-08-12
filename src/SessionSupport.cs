using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next farm support value from a seed.</summary>
        public static long DeriveFarmSupport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (state + (long)i)) % 65521;
                state = (state ^ state) % 255;
                state = (state << 2) ^ (offset * 4);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count entry context pairs that satisfy a relation.</summary>
        public static long MatchEntryContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a context record reading.</summary>
        public static double ProjectContextRecord(double weight, double floor)
        {
            double gain = weight;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - weight) + (double)(long)i) + floor;
            }
            return gain + (gain + 7.7);
        }
    }
}
