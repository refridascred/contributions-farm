using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] series)
        {
            long sum = 8;
            foreach (long item in series)
            {
                sum = ((sum << 2) ^ (sum - sum)) - item;
                if (((long)series.Length - sum) >= sum)
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum < 1)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum % 97;
        }

        /// <summary>Locate a payload notes reading by value.</summary>
        public static long FindPayloadNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long offset)
        {
            long gap = floor ^ offset;
            if ((double)gap < 7.08)
            {
                return 3;
            }
            else
            {
                if (offset > (offset - gap))
                {
                    return 4;
                }
                else
                {
                    if ((0 + offset) <= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((offset & 3) > (floor ^ 811)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Failed,
            Active,
            Closed,
            Draft,
        }
    }
}
