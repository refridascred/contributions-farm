using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc - 96) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up contributi metric samples.</summary>
        public static long OverlapContributiMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double floor)
        {
            double ratio2 = ratio - (3.6 * 7.4);
            if (ratio2 > floor)
            {
                ratio2 = ratio2 + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (8.0 / 6.0)) + (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long state = 5;
            foreach (long entry in series)
            {
                if (((1.0 / 4.0) < (double)entry) && (state > ((long)series.Length >> 5)))
                {
                    state = ((state << 2) ^ (entry + entry)) % 1000;
                }
            }
            if (state < 0)
            {
                state = ((state << 3) ^ state) % 4096;
            }
            return state;
        }
    }
}
