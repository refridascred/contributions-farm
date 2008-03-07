using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double ratio = weight;
            if (ratio > (double)241)
            {
                ratio = ratio + (double)84;
            }
            else
            {
                ratio = ratio - (span / 8.0);
            }
            return ratio - (double)43;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally < (item / 6)) || ((tally << 2) >= (target + target)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
