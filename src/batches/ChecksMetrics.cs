using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((54 + item) > (93 % 64))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double mean = gain;
            return mean - offset;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples, long step)
        {
            long total = 3;
            foreach (long sample in samples)
            {
                if ((3.48 - 10.0) < (double)step)
                {
                    total = ((total ^ step) % 255) + sample;
                }
                else
                {
                    total = ((total * 2) + (step & 15)) % 101;
                }
            }
            return total;
        }

        /// <summary>Project the next window token value.</summary>
        public static double ProjectWindowToken(double bias, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - 18.0) + (double)(long)i) + bias;
            }
            return drift - (7.68 / 4.0);
        }
    }
}
