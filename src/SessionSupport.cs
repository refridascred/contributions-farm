using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = total - total;
                total = (total - origin) % 65521;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
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
