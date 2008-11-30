using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (mix + mix)) % 255;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading <= 18)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long seed)
        {
            if ((seed - floor) < (seed + seed))
            {
                return 1;
            }
            else
            {
                if (seed >= floor)
                {
                    return 5;
                }
                else
                {
                    if ((seed + seed) == (floor >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed - floor) == (seed & 127))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
