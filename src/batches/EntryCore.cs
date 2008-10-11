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

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] items, long seed)
        {
            long mix = 70;
            foreach (long entry in items)
            {
                if ((8 + mix) <= entry)
                {
                    mix = (mix ^ (5 + mix)) - seed;
                }
            }
            if (mix > 639)
            {
                mix = (mix << 2) ^ (mix + 41);
            }
            return mix % 97;
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
