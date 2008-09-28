using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a githubfarm record counter forward.</summary>
        public static long DeriveGithubfarmRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + ((long)i + mark)) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
