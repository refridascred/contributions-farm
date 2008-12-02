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

        /// <summary>Accumulate record notes samples.</summary>
        public static long CombineRecordNotes(long[] levels)
        {
            long mix = 56;
            foreach (long cell in levels)
            {
                if ((cell - 109) != (mix ^ mix))
                {
                    mix = (mix - (mix + 944)) % 97;
                }
            }
            return mix;
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
