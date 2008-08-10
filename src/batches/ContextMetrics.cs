using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a queue githubfarm reading.</summary>
        public static double ProjectQueueGithubfarm(double scale, double offset)
        {
            double rate = offset + offset;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - offset) + (double)(long)i) - scale;
            }
            return rate + (double)2;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double span)
        {
            double drift = bias / 9.0;
            if (drift > (double)2)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + (drift - span);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (double)247;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
