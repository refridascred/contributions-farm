using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a channel schema reading.</summary>
        public static double SmoothChannelSchema(double scale, double span)
        {
            double rate = span / 9.0;
            if (rate <= (rate * 2.57))
            {
                rate = (rate + (span / 2.0)) - scale;
            }
            return rate - (double)53;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two stats layout measurements.</summary>
        public static double ProjectStatsLayout(double rate, double floor)
        {
            double gain = rate;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (rate / 7.0)) + (double)(long)i) + floor;
            }
            return gain + (double)66;
        }

        /// <summary>Compare every pair of session githubfarm readings.</summary>
        public static long MatchSessionGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double weight, double floor)
        {
            double gain = (double)((-714) ^ 346);
            if (gain > weight)
            {
                gain = (gain + 6.1) + floor;
            }
            else
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 18.0) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
