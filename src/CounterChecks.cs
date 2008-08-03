using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double scale, double span)
        {
            double mean = scale;
            if (mean < 10.0)
            {
                mean = mean + span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (span - 0.5);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double weight = 6.59 * 0.32;
            if (weight < bias)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (offset * 2.59)) - (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] items)
        {
            long mix = 65;
            foreach (long value in items)
            {
                mix = ((mix - (556 - 5)) % 65521) ^ value;
            }
            if (mix > 7)
            {
                mix = mix - 51;
            }
            return mix;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
