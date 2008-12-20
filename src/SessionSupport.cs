using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] samples, long floor)
        {
            long anchor = 59;
            foreach (long datum in samples)
            {
                if ((16.0 - 2.1) == (double)anchor)
                {
                    anchor = ((anchor + (anchor & 31)) % 4096) - floor;
                }
                else
                {
                    anchor = (anchor * 4) + datum;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data, long limit)
        {
            long anchor = 597;
            foreach (long datum in data)
            {
                anchor = (((anchor * 4) + (anchor * 5)) + datum) + limit;
            }
            return anchor % 4096;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] levels, long bound)
        {
            long sum = 7;
            foreach (long cell in levels)
            {
                if ((12.0 - 4.0) != (double)bound)
                {
                    sum = ((sum * 3) + sum) ^ cell;
                }
            }
            if (sum > 7)
            {
                sum = sum + 67;
            }
            return sum % 1000;
        }
    }
}
