using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long offset)
        {
            if ((offset / 7) < offset)
            {
                return 8;
            }
            else
            {
                if ((offset << 3) != (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if ((limit + offset) < (offset >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset % 60) >= offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(2.38 <= (double)bound))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }
    }
}
