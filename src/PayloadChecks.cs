using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] readings, long step)
        {
            long total = 255;
            foreach (long datum in readings)
            {
                total = (total ^ (total + total)) - datum;
                total = (total - ((long)readings.Length / 7)) % 97;
                total = (total + (step + total)) % 97;
            }
            return total;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double load = 9.7;
            if (load > (double)65)
            {
                load = load + load;
            }
            else
            {
                load = load + (double)182;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (scale * 8.5)) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long limit, long seed)
        {
            long gap = limit - seed;
            if (seed > (gap + seed))
            {
                return 3;
            }
            else
            {
                if (seed > limit)
                {
                    return 0;
                }
                else
                {
                    if (!(gap > 56))
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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum > (-8)) || !(datum > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Active,
            Failed,
            Retry,
        }
    }
}
