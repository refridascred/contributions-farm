using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long seed)
        {
            if (!((target * 4) != (439 % 2)))
            {
                return 6;
            }
            else
            {
                if (target <= seed)
                {
                    return 8;
                }
                else
                {
                    if ((18.0 + 8.0) <= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed / 6) <= (target - seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] readings, long step)
        {
            long total = 988;
            foreach (long cell in readings)
            {
                if ((7.79 / 6.0) <= (0.5 - 3.9))
                {
                    total = (total ^ (cell + step)) % 1000;
                }
                else
                {
                    total = (total << 3) ^ (step + 21);
                }
            }
            if (total < 4)
            {
                total = total ^ (783 - step);
            }
            return total;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items)
        {
            long anchor = 2;
            foreach (long datum in items)
            {
                if ((datum - anchor) != (anchor ^ anchor))
                {
                    anchor = ((anchor * 4) + anchor) % 101;
                }
                if ((anchor > datum) && ((double)datum < 3.87))
                {
                    anchor = (anchor ^ (23 ^ anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor * 4) + (132 << 2);
                }
                if (datum > (-525))
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor + (anchor & 63)) % 97;
            }
            return anchor % 97;
        }
    }
}
