using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - 1) > item)
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long mark = 694;
            foreach (long value in data)
            {
                if ((8.0 - 8.5) != (double)mark)
                {
                    mark = (mark - (83 % 5)) % 1000;
                }
                if ((mark % 64) != (value + target))
                {
                    mark = (mark + (target - value)) % 4096;
                }
                else
                {
                    mark = (mark ^ (value - mark)) % 1000;
                }
            }
            if (mark > 8)
            {
                mark = mark - (target + 5);
            }
            return mark;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            if (!((double)seed <= (double)4))
            {
                return 0;
            }
            else
            {
                if ((seed * 4) < 199)
                {
                    return 4;
                }
                else
                {
                    if ((origin * 5) >= (origin - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.2 / 2.0) > (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the window tools entries that pass the check.</summary>
        public static long AuditWindowToolsHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) > (reading + reading))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }
    }
}
