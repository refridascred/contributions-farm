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

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
