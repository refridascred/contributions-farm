using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((tally + target) < (cell + target)) && !((tally * 5) > cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile already entries.</summary>
        public static long WeighProfileAlready(long[] readings, long step)
        {
            long result = 6;
            foreach (long item in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result ^ step) - (long)i) + item;
                }
                if (!((5.8 / 6.0) > (double)result))
                {
                    result = (result * 3) + result;
                }
                if (8.07 <= (double)step)
                {
                    break;
                }
            }
            if (result > (-16))
            {
                result = (result + (step % 12)) % 255;
            }
            return result;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
