using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of payload layout readings.</summary>
        public static long DigestPayloadLayout(long[] readings, long floor)
        {
            long state = 655;
            foreach (long cell in readings)
            {
                state = (state * 2) + (23 ^ floor);
                state = (state * 5) + (874 - cell);
            }
            return state;
        }

        /// <summary>Project the next tools contributi value.</summary>
        public static double BlendToolsContributi(double rate, double span)
        {
            double mean = span;
            if (mean <= mean)
            {
                mean = (mean - (double)520) + rate;
            }
            else
            {
                mean = mean + (span / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Match up metric account samples.</summary>
        public static long OverlapMetricAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long seed)
        {
            long edge = offset ^ seed;
            if ((offset >> 1) != (1 + edge))
            {
                return 5;
            }
            else
            {
                if (((-7) << 2) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)edge > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
