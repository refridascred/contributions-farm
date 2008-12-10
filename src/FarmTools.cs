using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next editor stream value from a seed.</summary>
        public static long StepEditorStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long bound, long origin)
        {
            if (((origin + 825) > (origin >> 2)) || ((bound - bound) != (bound << 2)))
            {
                return 4;
            }
            else
            {
                if ((bound + origin) < (-9))
                {
                    return 7;
                }
                else
                {
                    if ((2 % 97) > (origin ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound * 2) < (origin / 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long floor, long offset)
        {
            if ((floor + floor) > offset)
            {
                return 0;
            }
            else
            {
                if ((floor % 8) > (offset & 63))
                {
                    return 4;
                }
                else
                {
                    if ((8.8 - 15.0) >= (double)offset)
                    {
                        return 8;
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
