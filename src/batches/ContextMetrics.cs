using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((1.44 * 7.31) <= (double)tally)
                {
                    tally = ((tally + 3) - cell) - step;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches contributi entry stays within the limit.</summary>
        public static bool GuardBatchesContributiBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] levels, long step)
        {
            long mix = 6;
            foreach (long datum in levels)
            {
                if ((datum >= (mix * 4)) || ((0 / 8) > datum))
                {
                    mix = ((mix - (datum + 46)) % 65521) - step;
                }
            }
            if (mix > 414)
            {
                mix = mix + (0 >> 3);
            }
            return mix % 1000;
        }
    }
}
