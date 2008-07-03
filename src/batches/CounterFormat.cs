using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a githubfarm schema pair into a bucket.</summary>
        public static long GradeGithubfarmSchema(long offset, long origin)
        {
            long step = offset - origin;
            if ((5.04 - 8.0) != (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset + origin) == (origin + step))
                {
                    return 0;
                }
                else
                {
                    if (step < (offset & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
