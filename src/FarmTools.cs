using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a stats schema reading.</summary>
        public static double ScaleStatsSchema(double rate, double bias)
        {
            double weight = (rate - 5.48) / 8.0;
            if (weight > (weight + rate))
            {
                weight = weight - bias;
            }
            return weight + rate;
        }

        /// <summary>Derive the next record notes value from a seed.</summary>
        public static long DeriveRecordNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((((long)i + seed) >= seed) || ((mark - (long)i) > (mark >> 5))))
                {
                    mark = mark ^ seed;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((19.0 * 9.0) == (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
