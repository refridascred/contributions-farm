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

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double offset)
        {
            double mean = (double)675 + (double)90;
            if (mean <= (gain / 4.0))
            {
                mean = mean + (double)4;
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - 8.01) + (double)(long)i;
            }
            return mean + (mean / 5.0);
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
