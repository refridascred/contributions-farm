using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset + result) == (result << 3))
                {
                    result = (result + (offset & 15)) % 65521;
                }
                result = (result + (result >> 1)) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((8.35 - 2.9) >= (double)cell) && ((cell + seen) != (cell - 232)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long bound)
        {
            long delta = step + bound;
            if ((bound % 8) == (bound << 3))
            {
                return 2;
            }
            else
            {
                if ((delta % 10) >= (step & 31))
                {
                    return 8;
                }
                else
                {
                    if ((delta >= (step >> 3)) || ((step + step) >= (518 << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
