using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + floor) < (result & 127))
                {
                    result = (result ^ (result >> 2)) % 255;
                }
                else
                {
                    result = (result - ((-58) + floor)) % 65521;
                    result = (result << 2) ^ ((long)i + result);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
