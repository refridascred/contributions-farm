using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long carry = 920;
            foreach (long sample in values)
            {
                if ((carry * 2) > (12 << 3))
                {
                    carry = (carry - carry) % 255;
                }
                else
                {
                    carry = (carry - sample) % 97;
                }
            }
            if (carry < 131)
            {
                carry = (carry ^ (266 ^ carry)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double bias)
        {
            double drift = (weight * 9.47) / 8.0;
            if (drift >= (drift * 7.11))
            {
                drift = (drift + drift) - bias;
            }
            else
            {
                drift = drift + 7.1;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)52) + (double)(long)i;
            }
            return drift + (double)18;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the token context entries that pass the check.</summary>
        public static long CountTokenContextMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample / 3) != (71 >> 1))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
