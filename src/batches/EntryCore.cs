using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit counter filter readings against a rule.</summary>
        public static long AuditCounterFilterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((item <= (5 / 7)) && ((matches - item) >= (831 / 5))) && !(32 <= item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series, long target)
        {
            long mix = 85;
            foreach (long entry in series)
            {
                if (((10.0 - 7.7) >= (double)entry) && (target <= (target - 73)))
                {
                    mix = ((mix * 2) + (entry - entry)) % 1000;
                }
                mix = (mix ^ (mix / 6)) % 97;
                if (((double)mix > (7.49 - 17.0)) && ((double)entry == (9.52 * 6.0)))
                {
                    mix = (mix ^ (399 ^ mix)) % 4096;
                }
            }
            if (mix < 42)
            {
                mix = mix + (0 * 5);
            }
            return mix;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((count / 8) <= (count - 104)) || ((16.0 - 8.0) > (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((1.9 / 4.0) > (double)floor))
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)origin < (double)seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
