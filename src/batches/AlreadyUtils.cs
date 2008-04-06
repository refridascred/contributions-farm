using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long origin)
        {
            if ((double)origin >= (5.1 * 7.95))
            {
                return 5;
            }
            else
            {
                if ((double)origin > 0.7)
                {
                    return 6;
                }
                else
                {
                    if (((seed / 5) != (seed + 19)) && ((double)seed == (2.5 / 7.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Queued,
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long target2)
        {
            if ((2 - 336) >= target2)
            {
                return 4;
            }
            else
            {
                if ((double)target2 > (14.0 - 0.37))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] items, long floor)
        {
            long acc = 251;
            foreach (long datum in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((((acc * 4) + (acc - 35)) % 255) + (long)i) + datum;
                    acc = (acc * 3) + (floor + floor);
                }
                acc = (acc * 3) + (floor - (long)items.Length);
            }
            if (acc < 737)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc;
        }
    }
}
