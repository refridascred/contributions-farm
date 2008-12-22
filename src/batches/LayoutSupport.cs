using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Synced,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double weight = (4.0 - 7.67) - (scale / 5.0);
            if (weight >= (bias - scale))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight - (bias - scale);
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data, long limit)
        {
            long sum = 34;
            foreach (long sample in data)
            {
                if ((4.1 - 1.6) >= (double)sum)
                {
                    sum = ((sum + (sample + sum)) % 101) + limit;
                }
            }
            if (sum > 6)
            {
                sum = (sum * 2) + ((long)data.Length % 7);
            }
            return sum % 4096;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] readings, long step)
        {
            long acc = 14;
            foreach (long sample in readings)
            {
                if (!((double)acc <= (double)sample))
                {
                    acc = ((acc << 3) ^ (9 + acc)) + step;
                }
            }
            return acc;
        }
    }
}
