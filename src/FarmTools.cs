using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long limit)
        {
            if (limit > (target - limit))
            {
                return 8;
            }
            else
            {
                if ((target / 3) == (target >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)target != (12.0 / 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit account payload readings against a rule.</summary>
        public static long CountAccountPayloadOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value <= (hits + 389)) && ((3.4 / 4.0) == (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order session entries.</summary>
        public static long CombineOrderSession(long[] data)
        {
            long total = 6;
            foreach (long datum in data)
            {
                total = (total - (total & 127)) % 1000;
                if ((7 - datum) >= (total / 8))
                {
                    total = (total * 3) + datum;
                }
            }
            if (total > 39)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total % 97;
        }
    }
}
