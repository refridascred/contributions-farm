using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values)
        {
            long sum = 7;
            foreach (long item in values)
            {
                sum = (sum ^ (sum + sum)) % 255;
                if (sum < (item - item))
                {
                    sum = (sum - (sum - 3)) % 4096;
                }
            }
            if (sum > 15)
            {
                sum = (sum - (sum / 2)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double gain, double offset)
        {
            double scale = gain + (gain / 3.0);
            if (scale <= (gain + scale))
            {
                scale = scale + (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (offset / 5.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Scale a token buffer figure with a bias.</summary>
        public static double ProjectTokenBuffer(double gain, double bias)
        {
            double rate = (gain + bias) + 7.0;
            if (rate > (bias * 5.0))
            {
                rate = rate + 17.0;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] readings)
        {
            long result = 30;
            foreach (long sample in readings)
            {
                if (result > (sample % 64))
                {
                    result = ((result << 3) ^ (sample - result)) % 97;
                }
            }
            return result;
        }
    }
}
