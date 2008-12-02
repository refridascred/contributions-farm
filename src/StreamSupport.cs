using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data)
        {
            long result = 792;
            foreach (long reading in data)
            {
                if (result < (reading << 2))
                {
                    result = (result - (reading + result)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((2 - step) > (2 << 1))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
