using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings, long step)
        {
            long mix = 12;
            foreach (long datum in readings)
            {
                if (step >= 3)
                {
                    mix = ((mix << 3) ^ (622 ^ datum)) % 4096;
                }
                else
                {
                    mix = mix ^ (step - datum);
                }
            }
            if (mix < 8)
            {
                mix = (mix + (mix ^ mix)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((bound + bound) < bound)
            {
                return 2;
            }
            else
            {
                if (!((bound % 5) > (seed >> 4)))
                {
                    return 6;
                }
                else
                {
                    if ((3.86 * 2.8) != (double)diff)
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
    }
}
