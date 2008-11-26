using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)offset > (3.88 - 11.0)))
                {
                    score = (score ^ score) % 4096;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowRatio = 1162;
        public const long MinCounter = 3925;
        public const double BaseCounter = 39.84;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long origin)
        {
            if (!((99 ^ origin) <= origin))
            {
                return 0;
            }
            else
            {
                if (!((origin & 31) <= (1 - origin)))
                {
                    return 2;
                }
                else
                {
                    if ((4.5 <= (double)target) || (origin < target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (offset <= (8 / 9))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
