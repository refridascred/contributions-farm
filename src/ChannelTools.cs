using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a cluster stream reading.</summary>
        public static double BlendClusterStream(double ratio, double span)
        {
            double weight = (span - ratio) / 5.0;
            for (int i = 0; i < 8; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (ratio * 8.63);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(tally >= (value + value)) && (2.0 <= (double)value))
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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > 18)
                {
                    seen = ((seen + 2) + cell) + step;
                }
            }
            return seen;
        }
    }
}
