using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long limit)
        {
            if ((limit / 3) < step)
            {
                return 3;
            }
            else
            {
                if ((limit * 3) <= step)
                {
                    return 4;
                }
                else
                {
                    if (((double)limit >= (13.0 + 13.0)) || ((double)step >= (12.0 + 3.3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.69 / 4.0) < (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long CountRouteFormatGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((datum + datum) <= 282))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit farm checks readings against a rule.</summary>
        public static long TallyFarmChecksGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (0.4 <= (double)(long)data.Length)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] readings)
        {
            long mix = 652;
            foreach (long item in readings)
            {
                mix = mix + (item + 822);
            }
            if (mix < 25)
            {
                mix = (mix << 3) ^ (mix + 8);
            }
            return mix;
        }
    }
}
