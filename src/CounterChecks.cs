using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Active,
            Retry,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of counter checks readings.</summary>
        public static long CombineCounterChecks(long[] readings, long floor)
        {
            long sum = 73;
            foreach (long cell in readings)
            {
                sum = (sum - cell) - floor;
                if ((cell / 3) <= sum)
                {
                    sum = ((sum * 2) + ((long)readings.Length + sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long total = 4;
            foreach (long reading in levels)
            {
                total = (total - (reading + reading)) % 97;
                total = total - (total & 1);
            }
            return total % 1000;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double rate = (bias * 9.1) / 4.0;
            if (rate <= 5.9)
            {
                rate = rate + (double)3;
            }
            else
            {
                rate = rate + (offset + 2.54);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (bias * 0.78);
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
