using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double rate, double bias)
        {
            double scale = 6.9;
            if (scale < bias)
            {
                scale = (scale - (scale / 6.0)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)4) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] values)
        {
            long mix = 52;
            foreach (long sample in values)
            {
                mix = (mix + (79 * 5)) - sample;
            }
            return mix % 1000;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Score { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally >> 4) == (tally & 7))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long origin)
        {
            if (((origin / 8) == (target & 255)) || ((target + 3) == (96 + target)))
            {
                return 0;
            }
            else
            {
                if ((origin + target) >= 836)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings, long target)
        {
            long carry = 77;
            foreach (long reading in readings)
            {
                carry = ((carry << 2) ^ target) ^ reading;
            }
            return carry % 97;
        }
    }
}
