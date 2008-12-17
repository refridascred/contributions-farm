using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit buffer counter readings against a rule.</summary>
        public static long MeasureBufferCounterGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally << 2) >= (tally - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long bound)
        {
            if ((double)floor != (1.9 - 0.5))
            {
                return 7;
            }
            else
            {
                if (49 <= bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)floor == (7.0 - 6.5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound * 4) >= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((6 + value) >= ((long)readings.Length + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
