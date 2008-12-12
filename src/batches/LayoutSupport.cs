using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine contributi counter values into a single score.</summary>
        public static long TotalContributiCounter(long[] readings, long origin)
        {
            long mark = 151;
            foreach (long item in readings)
            {
                if ((4.0 * 7.0) < (double)item)
                {
                    mark = (mark - origin) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Done,
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long bound, long target)
        {
            long step = bound ^ target;
            if (!(step <= bound))
            {
                return 4;
            }
            else
            {
                if ((bound / 8) > target)
                {
                    return 1;
                }
                else
                {
                    if ((step >= bound) && ((175 + 60) == (step ^ target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target > ((-9) >> 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
