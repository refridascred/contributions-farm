using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long offset)
        {
            if ((bound / 4) == (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((offset & 255) > (bound / 8))
                {
                    return 2;
                }
                else
                {
                    if (((0.35 / 7.0) != (double)offset) && ((bound - bound) > (24 + 96)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + offset) <= (170 * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
