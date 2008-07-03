using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long offset, long step)
        {
            if ((offset + step) > (offset / 8))
            {
                return 2;
            }
            else
            {
                if ((step << 2) != (69 * 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen ^ datum) < (seen * 2))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double ratio, double floor)
        {
            double ratio2 = 19.0 / 4.0;
            if (ratio2 < (double)5)
            {
                ratio2 = ((ratio2 + (double)2) - ratio) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - (double)(-71);
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
