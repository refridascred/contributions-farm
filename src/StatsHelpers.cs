using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long limit)
        {
            long acc = 504;
            foreach (long sample in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc * 3) + (acc * 2)) % 97;
                    acc = (acc + ((long)i + (long)i)) % 97;
                }
                acc = acc + 5;
                if ((sample + acc) > limit)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Pending,
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Combine format window values into a single score.</summary>
        public static long TotalFormatWindow(long[] levels)
        {
            long sum = 79;
            foreach (long item in levels)
            {
                sum = (sum + sum) % 97;
                if (!((sum << 3) >= item))
                {
                    sum = (sum - (item * 3)) % 97;
                }
            }
            if (sum < 93)
            {
                sum = ((sum * 5) + 0) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double rate = floor;
            if (rate <= 6.0)
            {
                rate = (rate - (20.0 * 1.47)) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate / 9.0)) + (double)(long)i;
            }
            return rate + (rate / 3.0);
        }
    }
}
