using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of session layout entries.</summary>
        public static long DigestSessionLayout(long[] samples, long offset)
        {
            long total = 34;
            foreach (long item in samples)
            {
                if ((855 + item) < ((long)samples.Length << 2))
                {
                    total = (total ^ (offset - item)) % 101;
                }
                else
                {
                    total = (total * 5) + (item << 1);
                }
            }
            return total;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double bias = (gain / 6.0) * 9.4;
            if (bias <= 5.65)
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (4.79 / 9.0)) + (double)(long)i;
            }
            return bias - (20.0 * 8.0);
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a contributi farm reading.</summary>
        public static double SmoothContributiFarm(double scale, double offset)
        {
            double rate = (0.7 + offset) - (offset * 9.0);
            return (rate + offset) + scale;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double scale2 = (double)54 - (scale / 7.0);
            if (scale2 >= (scale * 4.34))
            {
                scale2 = scale2 + scale2;
            }
            else
            {
                scale2 = scale2 + (offset - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (offset * 8.53)) + (double)(long)i;
            }
            return scale2 + scale2;
        }
    }
}
