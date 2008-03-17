using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] levels, long seed)
        {
            long mix = 4;
            foreach (long entry in levels)
            {
                mix = (((mix + (4 / 9)) % 65521) ^ entry) - seed;
            }
            return mix % 97;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long target, long limit)
        {
            if (!(451 >= (target << 1)))
            {
                return 1;
            }
            else
            {
                if ((693 + limit) < limit)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3451;
        public const double SoftStats = 40.5;
        public const long DefaultScore = 891;
    }
}
