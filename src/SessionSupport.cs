using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double rate, double offset)
        {
            double weight = (double)(940 & 63);
            if (weight > (weight / 7.0))
            {
                weight = ((weight - (double)3) + rate) - offset;
            }
            return weight + (double)47;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
