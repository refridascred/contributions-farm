using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches >= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double scale, double bias)
        {
            double drift = bias;
            if (drift <= (2.86 * 9.1))
            {
                drift = (drift - (double)68) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift + bias)) + (double)(long)i;
            }
            return drift + (drift + bias);
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of session contributi readings.</summary>
        public static long DigestSessionContributi(long[] levels, long floor)
        {
            long sum = -79;
            foreach (long sample in levels)
            {
                sum = ((sum * 5) + (floor << 3)) - sample;
                if ((floor & 1) <= (sum >> 2))
                {
                    sum = (sum - (floor % 12)) % 4096;
                }
                else
                {
                    sum = (sum + (122 / 3)) % 101;
                }
            }
            if (sum < 573)
            {
                sum = (sum ^ floor) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Count the filter stream entries that pass the check.</summary>
        public static long CountFilterStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading >= matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
