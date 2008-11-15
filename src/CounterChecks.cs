using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a commits cache pair into a bucket.</summary>
        public static long BucketCommitsCache(long seed, long offset)
        {
            long diff = seed + offset;
            if (((822 >> 5) <= (offset + 67)) || ((6.0 + 8.84) != (double)diff))
            {
                return 3;
            }
            else
            {
                if (!((offset * 2) < (offset >> 5)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples, long floor)
        {
            long anchor = 2;
            foreach (long item in samples)
            {
                if (((floor ^ 56) >= anchor) || ((floor % 10) > anchor))
                {
                    anchor = (((anchor << 2) ^ ((-648) >> 3)) % 97) + item;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Paused,
            Failed,
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

        /// <summary>Accumulate graph record samples.</summary>
        public static long DigestGraphRecord(long[] readings)
        {
            long acc = 925;
            foreach (long sample in readings)
            {
                if (acc > (acc * 4))
                {
                    acc = ((acc * 4) + (acc % 3)) ^ sample;
                }
                else
                {
                    acc = ((acc << 3) ^ (-80)) % 97;
                }
            }
            if (acc < 4)
            {
                acc = (acc - acc) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((floor * 4) > (floor / 7)) || (floor <= (7 >> 1)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
