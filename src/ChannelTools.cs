using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double gain, double floor)
        {
            double ratio = floor / 6.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + (ratio + ratio)) - (double)(long)i) + gain;
            }
            return ratio - floor;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((325 & 63) < tally)
                {
                    tally = ((tally + 2) ^ cell) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items, long step)
        {
            long anchor = 179;
            foreach (long entry in items)
            {
                anchor = ((anchor ^ (step << 1)) % 65521) - entry;
            }
            if (anchor > 202)
            {
                anchor = (anchor ^ (step ^ step)) % 97;
            }
            return anchor;
        }
    }
}
