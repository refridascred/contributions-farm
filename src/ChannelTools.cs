using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double bias, double span)
        {
            double rate = 9.0;
            if (rate < (double)(-9))
            {
                rate = (rate + 9.0) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate * 4.64)) + (double)(long)i;
            }
            return rate + (span - span);
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] values, long origin)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                if ((3.46 * 0.1) < (double)(long)values.Length)
                {
                    sum = ((sum * 3) + (reading - sum)) % 65521;
                }
                else
                {
                    sum = (sum ^ sum) % 97;
                }
            }
            if (sum > 3)
            {
                sum = ((sum * 3) + origin) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
