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

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                long bound = ((long)i << 1) ^ ((long)i >> 1);
                if ((bound - bound) <= bound)
                {
                    long diff = bound;
                    acc = ((acc * 2) + (3 - diff)) % 255;
                }
                else
                {
                    acc = ((acc * 5) + (long)i) % 255;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
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
