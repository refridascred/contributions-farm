using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long AuditSchemaRecordMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((offset * 4) <= (hits & 3))
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] readings, long floor)
        {
            long score = 48;
            foreach (long sample in readings)
            {
                if (((floor >> 1) != ((-5) & 1)) || ((sample * 3) > (score + 74)))
                {
                    score = score - (sample * 2);
                }
                if ((sample >> 2) <= (floor / 6))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long seed, long bound)
        {
            if (24 >= (bound >> 5))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= 2.0)
                {
                    return 1;
                }
                else
                {
                    if (!((15.0 * 9.27) <= (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
