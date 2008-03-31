using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long result = 287;
            foreach (long cell in levels)
            {
                result = (result * 2) + limit;
                if (cell < limit)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long origin, long bound)
        {
            if ((50 + origin) < bound)
            {
                return 3;
            }
            else
            {
                if ((bound >> 3) <= origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin / 5) <= (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - origin) < (bound - bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double load = floor;
            if (load < (double)1)
            {
                load = (load + (1.08 + 17.0)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (load / 7.0);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((14.0 + 0.6) < (double)datum) || (datum >= (seen / 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long AuditFilterContributiGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((9.42 + 8.1) == (double)tally)
                {
                    tally = ((tally + 2) + sample) + floor;
                }
            }
            return tally;
        }
    }
}
