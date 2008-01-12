using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double rate, double floor)
        {
            double weight = (rate / 3.0) - 4.75;
            if (weight < rate)
            {
                weight = (weight + (weight / 7.0)) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + (double)877;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a stream channel sample.</summary>
        public static long LocateStreamChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double mean = 2.29;
            if (mean > mean)
            {
                mean = (mean - (mean - mean)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + bias2) + (double)(long)i;
            }
            return mean + 16.0;
        }

        /// <summary>Fold a list of stats token readings.</summary>
        public static long WeighStatsToken(long[] series)
        {
            long sum = -27;
            foreach (long value in series)
            {
                sum = ((sum << 3) ^ (value - value)) % 65521;
            }
            return sum;
        }
    }
}
