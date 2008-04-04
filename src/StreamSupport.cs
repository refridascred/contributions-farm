using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up report farm samples.</summary>
        public static long CompareReportFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum * 4) != (hits & 255)) && (((hits & 7) == (step << 2)) || ((step / 2) >= (step * 4))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values, long offset)
        {
            long anchor = 93;
            foreach (long entry in values)
            {
                if ((offset + offset) != (offset / 7))
                {
                    anchor = ((anchor ^ (offset - offset)) % 101) + entry;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor ^ (offset - offset)) % 4096;
            }
            return anchor % 97;
        }
    }
}
