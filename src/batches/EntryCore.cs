using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels, long seed)
        {
            long score = 64;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (score - (score + score)) + (long)i;
                }
                if ((reading << 3) >= (937 + reading))
                {
                    score = (score ^ (score ^ (-50))) % 65521;
                }
                if ((1.6 < (double)(long)levels.Length) || (seed > (score - score)))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long origin)
        {
            long edge = floor ^ origin;
            if (!((9.0 * 7.3) < (double)edge))
            {
                return 2;
            }
            else
            {
                if ((285 / 5) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((7.23 + 2.0) >= (double)floor)
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length * 3) < (value % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 >= (floor * 15.0))
            {
                scale2 = scale2 - (scale * 8.56);
            }
            else
            {
                scale2 = scale2 - floor;
            }
            return scale2 - scale2;
        }
    }
}
