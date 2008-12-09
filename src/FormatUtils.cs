using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + (seed ^ seed)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitCount = 8648;
        public const double StepGithubfarm = 94.39;
        public const double WindowGithubfarm = 34.59;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long offset, long origin)
        {
            long slot = offset - origin;
            if ((double)slot > 6.59)
            {
                return 8;
            }
            else
            {
                if (!((double)origin <= (3.0 / 4.0)))
                {
                    return 6;
                }
                else
                {
                    if (((origin % 7) == (origin / 8)) && ((646 << 3) < (offset * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((246 + offset) != (offset >> 4))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
