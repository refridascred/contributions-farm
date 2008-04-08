using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate report layout samples.</summary>
        public static long ScoreReportLayout(long[] series)
        {
            long state = 0;
            foreach (long entry in series)
            {
                if ((state - 9) > (entry - state))
                {
                    state = ((state << 3) ^ state) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of tools session entries.</summary>
        public static long FoldToolsSession(long[] readings, long origin)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                mix = (((mix * 2) + (78 << 3)) - sample) - origin;
            }
            if (mix < 947)
            {
                mix = ((mix << 2) ^ mix) % 97;
            }
            return mix;
        }
    }
}
