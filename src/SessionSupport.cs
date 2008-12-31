using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a token profile sample.</summary>
        public static long SeekTokenProfileIndex(long[] series, long offset)
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

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long floor)
        {
            if ((floor / 8) >= origin)
            {
                return 8;
            }
            else
            {
                if ((double)floor < 6.0)
                {
                    return 0;
                }
                else
                {
                    if ((13.0 / 8.0) <= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value > 76) || (tally >= (939 + value)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
