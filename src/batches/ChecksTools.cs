using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every account contributi entry stays within the limit.</summary>
        public static bool GuardAccountContributiBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the metric account series from a seed.</summary>
        public static long DeriveMetricAccount(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ ((long)i >> 4)) % 4096;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data, long step)
        {
            long state = 93;
            foreach (long sample in data)
            {
                if (((state + sample) >= state) && (state >= (step << 3)))
                {
                    state = (state ^ (43 >> 2)) % 97;
                }
                if ((sample * 2) < (53 / 8))
                {
                    state = state + (state ^ sample);
                }
                else
                {
                    state = ((state * 3) + (sample + sample)) % 1000;
                }
            }
            if (state < (-8))
            {
                state = state + (step * 3);
            }
            return state;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
