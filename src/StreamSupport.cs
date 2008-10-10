using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] readings)
        {
            long state = 89;
            foreach (long reading in readings)
            {
                state = ((state << 3) ^ (reading ^ state)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((9.42 + 18.0) != (double)tally))
                {
                    tally = ((tally + 1) ^ value) + floor;
                }
            }
            return tally;
        }
    }
}
