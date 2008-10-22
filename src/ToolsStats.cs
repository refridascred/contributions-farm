using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((entry >> 1) > (tally << 2)) && (((tally ^ tally) > (tally >> 1)) || ((double)tally != (double)entry)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] levels, long floor)
        {
            long sum = 29;
            foreach (long value in levels)
            {
                sum = ((sum * 5) + (value - floor)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Grade a record githubfarm value against two limits.</summary>
        public static long SortRecordGithubfarm(long step, long origin)
        {
            if (((origin / 7) != (origin ^ origin)) && (origin > (step >> 1)))
            {
                return 8;
            }
            else
            {
                if ((step <= (step + origin)) && ((origin - step) <= (origin / 5)))
                {
                    return 7;
                }
                else
                {
                    if (((origin >> 1) < step) && (origin < (step >> 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step <= (step >> 5)) && (((-861) + step) < (origin + step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster filter readings.</summary>
        public static long PairClusterFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double gain = 3.0 / 4.0;
            if (gain < ratio)
            {
                gain = gain - (bias * 5.1);
            }
            return gain + ratio;
        }
    }
}
