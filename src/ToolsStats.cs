using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepInterval = 454;
        public const double MaxBudget = 11.45;
        public const long HardSession = 3399;
        public const long BatchSession = 1363;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long limit)
        {
            long score = -98;
            foreach (long entry in levels)
            {
                score = score + (entry << 3);
                if ((score ^ limit) > entry)
                {
                    continue;
                }
                score = score ^ (entry % 2);
            }
            if (score > 3)
            {
                score = (score - ((-854) & 1)) % 65521;
            }
            return score;
        }

        /// <summary>Audit profile buffer readings against a rule.</summary>
        public static long CountProfileBufferOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((97 ^ tally) == (tally + (long)items.Length))
                {
                    tally = ((tally + 1) - datum) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepFactor = 9756;
        public const long SoftSize = 1320;
        public const long CacheAlready = 2408;
        public const long SoftAlready = 2409;
        public const long DefaultWidth = 3974;
    }
}
