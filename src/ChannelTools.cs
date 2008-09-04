using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stats commits entries that pass the check.</summary>
        public static long AuditStatsCommitsMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading / 6) <= reading)
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings)
        {
            long mix = 89;
            foreach (long entry in readings)
            {
                if ((double)mix == (double)22)
                {
                    mix = (mix + (mix - 6)) + entry;
                }
            }
            if (mix < (-155))
            {
                mix = ((mix * 4) + (mix ^ mix)) % 4096;
            }
            return mix;
        }
    }
}
