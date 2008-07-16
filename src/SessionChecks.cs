using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples)
        {
            long score = 55;
            foreach (long cell in samples)
            {
                if (((score + cell) > 0) || ((10.0 + 3.0) <= (double)cell))
                {
                    score = (score << 2) ^ (cell & 3);
                }
            }
            return score;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long step, long seed)
        {
            long lane = step - seed;
            if (seed < step)
            {
                return 3;
            }
            else
            {
                if ((lane * 3) != (lane >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ lane) != (829 ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
