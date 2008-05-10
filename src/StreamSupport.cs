using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings, long offset)
        {
            long total = 750;
            foreach (long reading in readings)
            {
                total = (total * 5) + (total + offset);
                if ((offset + total) < (offset & 63))
                {
                    total = (total ^ (reading & 1)) % 1000;
                    break;
                }
                if ((offset + total) < (total << 2))
                {
                    total = total ^ (offset * 5);
                }
                else
                {
                    total = (total * 2) + (offset ^ 742);
                }
            }
            if (total < 332)
            {
                total = total ^ offset;
            }
            return total;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading > 3.15)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
