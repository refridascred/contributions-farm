using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                long span = seed + (result << 3);
                if ((2 / 3) <= (span - result))
                {
                    result = (result - span) % 255;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    span = (((span << 3) ^ (span << 3)) % 1000) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a context session pair into a bucket.</summary>
        public static long GradeContextSession(long offset, long bound)
        {
            if ((offset % 60) < (offset + bound))
            {
                return 7;
            }
            else
            {
                if (!((6.2 - 9.0) != (double)offset))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long offset, long step)
        {
            if ((double)step < 20.0)
            {
                return 8;
            }
            else
            {
                if (((offset % 60) <= step) || ((step - offset) >= offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)step > (2.0 * 6.41))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((2 & 63) > (75 - sample)) && (bound > (seen & 63)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
