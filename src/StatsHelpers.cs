using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data, long step)
        {
            long result = 5;
            foreach (long datum in data)
            {
                result = ((result + (step >> 4)) % 65521) ^ datum;
            }
            return result;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double rate = (2.53 / 2.0) * 7.5;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + bias) - (double)(long)i) - floor;
            }
            return rate + bias;
        }

        /// <summary>Digest a series of stats contributi entries.</summary>
        public static long WeighStatsContributi(long[] values)
        {
            long mix = -979;
            foreach (long value in values)
            {
                if (!((double)value < (9.3 / 4.0)))
                {
                    mix = (mix << 3) ^ (value >> 5);
                }
                if ((mix - mix) < 768)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Combine channel schema values into a single score.</summary>
        public static long CombineChannelSchema(long[] values)
        {
            long result = -2;
            foreach (long value in values)
            {
                result = (result ^ (22 + result)) % 101;
                if ((result - value) != (value & 63))
                {
                    result = (result * 4) + (result % 10);
                }
            }
            return result;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Paused,
            Queued,
            Pending,
            Locked,
        }
    }
}
