using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double scale, double offset)
        {
            double ratio = (double)((-56) + 23);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (scale / 3.0)) + (double)(long)i) - offset;
            }
            return ratio - 8.1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long origin, long step)
        {
            long prev = origin + step;
            if ((step << 2) >= (prev ^ prev))
            {
                return 0;
            }
            else
            {
                if (step > ((-5) ^ origin))
                {
                    return 2;
                }
                else
                {
                    if (((step * 5) > origin) || (origin >= (origin >> 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
