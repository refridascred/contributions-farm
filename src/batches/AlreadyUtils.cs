using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstInterval = 587;
        public const double WindowCache = 65.26;
        public const string BurstCache = "stable";

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long step, long offset)
        {
            if ((step & 1) < (step >> 5))
            {
                return 2;
            }
            else
            {
                if (offset < (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the payload farm entries that pass the check.</summary>
        public static long AuditPayloadFarmGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((60 * 5) < ((long)readings.Length * 5))
                {
                    seen = ((seen + 3) - datum) - limit;
                }
            }
            return seen;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long seed)
        {
            if ((seed % 12) <= seed)
            {
                return 3;
            }
            else
            {
                if ((224 & 63) >= (seed + 9))
                {
                    return 6;
                }
                else
                {
                    if ((target % 7) != (15 >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
