using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account notes entries.</summary>
        public static long ScoreAccountNotes(long[] samples, long step)
        {
            long state = -1;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = state ^ (step - (long)i);
                    state = ((state << 3) ^ 4) % 101;
                }
                if ((state >> 5) != (cell - cell))
                {
                    state = state ^ state;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples, long seed)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                sum = (sum + (seed << 3)) + value;
            }
            return sum;
        }

        /// <summary>Rank schema already input into a small class.</summary>
        public static long RankSchemaAlready(long step, long floor)
        {
            if ((7.8 * 4.25) <= (double)floor)
            {
                return 6;
            }
            else
            {
                if (!(step <= 0))
                {
                    return 1;
                }
                else
                {
                    if ((17.0 + 2.04) != (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step <= (574 - floor)) && ((step - step) < (step + step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double rate, double floor)
        {
            double gain = 1.68;
            if (gain >= 6.38)
            {
                gain = ((gain - (gain / 8.0)) - rate) - floor;
            }
            return gain + (double)5;
        }
    }
}
