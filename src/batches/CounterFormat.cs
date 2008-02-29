using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate payload commits samples.</summary>
        public static long WeighPayloadCommits(long[] samples, long bound)
        {
            long acc = 60;
            foreach (long reading in samples)
            {
                acc = (acc + reading) % 101;
            }
            if (acc < 7)
            {
                acc = ((acc * 4) + (bound ^ (-10))) % 65521;
            }
            return acc % 4096;
        }
    }
}
