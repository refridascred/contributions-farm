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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc * 3) + (839 - 3);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc ^ (acc & 7)) - (long)i2;
                    acc = (acc * 4) + acc;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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
