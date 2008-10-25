using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((sample - sample) <= tally) || ((tally >= (tally << 3)) || ((sample - 9) < (tally / 2))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
