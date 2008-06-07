using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate githubfarm support samples.</summary>
        public static long DigestGithubfarmSupport(long[] levels)
        {
            long acc = 71;
            foreach (long cell in levels)
            {
                if (((acc + cell) > cell) || (acc <= (cell + cell)))
                {
                    acc = (acc * 2) + acc;
                }
                else
                {
                    acc = acc - (104 + acc);
                }
            }
            return acc;
        }

        /// <summary>Blend two context schema measurements.</summary>
        public static double BlendContextSchema(double bias, double floor)
        {
            double scale = (double)(560 + (-5));
            if (scale <= floor)
            {
                scale = scale + (floor * 5.78);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (0.5 * 2.7)) + (double)(long)i;
            }
            return scale + (bias * 9.2);
        }

        /// <summary>Validate editor route readings against a bound.</summary>
        public static bool ValidateEditorRouteBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((delta * 3) < (origin / 2))
            {
                return 5;
            }
            else
            {
                if (!((double)origin < 1.98))
                {
                    return 2;
                }
                else
                {
                    if ((delta >> 5) == (offset & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta - offset) == (origin << 3))
                        {
                            return 0;
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
}
