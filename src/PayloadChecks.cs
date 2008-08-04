using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double bias)
        {
            double drift = bias;
            if (drift > drift)
            {
                drift = (drift + drift) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (2.22 * 0.1)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a graph githubfarm sample.</summary>
        public static long SeekGraphGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }
    }
}
