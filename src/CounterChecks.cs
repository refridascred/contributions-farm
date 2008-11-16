using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftScore = "primary";
        public const string IdleInterval = "primary-edge";
        public const long DefaultPayload = 4096;
        public const long MinPayload = 4631;
        public const long RetryPayload = 8204;

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long CountChecksLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((matches - 220) <= (3 / 9)) || ((matches ^ matches) > matches))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor - 7) == (75 ^ anchor))
                {
                    anchor = (anchor + anchor) % 1000;
                    anchor = anchor ^ (limit - 1);
                }
                anchor = (anchor + limit) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((target - item) <= item) && ((207 / 2) > (count ^ count))) && ((count > item) && ((53 + count) > (count + target))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long floor)
        {
            if ((step & 7) >= (733 - floor))
            {
                return 0;
            }
            else
            {
                if ((step > (floor & 3)) && ((90 >> 5) >= (step / 7)))
                {
                    return 3;
                }
                else
                {
                    if ((floor / 6) <= 5)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
