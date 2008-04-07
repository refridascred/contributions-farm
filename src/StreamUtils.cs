using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc - (acc * 2)) % 97) ^ (long)i2;
                }
                acc = (acc + acc) % 101;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits == (6.0 / 7.0))
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((matches <= (matches / 3)) || ((reading - matches) > (limit * 2))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((matches / 5) <= matches) || ((floor / 2) >= (floor >> 1)))
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen < (12.0 + 4.2))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
