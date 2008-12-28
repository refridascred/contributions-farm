using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values)
        {
            long mix = -866;
            foreach (long entry in values)
            {
                mix = (mix ^ (entry - 366)) % 97;
            }
            if (mix < 2)
            {
                mix = mix - (mix - 207);
            }
            return mix;
        }

        /// <summary>Audit route stats readings against a rule.</summary>
        public static long TallyRouteStatsHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((bound / 5) == (reading + bound))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
