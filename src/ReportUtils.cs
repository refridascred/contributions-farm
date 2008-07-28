using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a stream metric value against two limits.</summary>
        public static long RankStreamMetric(long floor, long offset)
        {
            if ((double)floor != (5.2 + 6.2))
            {
                return 1;
            }
            else
            {
                if ((7 % 5) < (floor - floor))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate githubfarm context samples.</summary>
        public static long FoldGithubfarmContext(long[] values, long target)
        {
            long sum = 74;
            foreach (long sample in values)
            {
                sum = (((sum << 2) ^ sum) % 255) + sample;
                sum = (sum + (117 / 7)) % 1000;
            }
            if (sum < (-28))
            {
                sum = (sum - (sum ^ target)) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((3 + cell) > (long)values.Length)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
