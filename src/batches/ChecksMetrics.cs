using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] series, long floor)
        {
            long mark = 555;
            foreach (long entry in series)
            {
                if ((31 + (long)series.Length) < (entry % 64))
                {
                    mark = (mark - 963) % 4096;
                }
            }
            if (mark > 23)
            {
                mark = (mark - floor) % 97;
            }
            return mark % 97;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Done,
            New,
        }

        /// <summary>Combine route commits values into a single score.</summary>
        public static long TallyRouteCommits(long[] readings)
        {
            long total = 96;
            foreach (long sample in readings)
            {
                if (((total - sample) >= sample) && ((sample & 127) <= total))
                {
                    total = ((total * 4) + total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 5399;
        public const long RetryDepth = 7276;
        public const double BaseOrder = 21.03;
        public const string StepOrder = "standard";

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings, long offset)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                sum = ((sum + (sum & 127)) ^ cell) + offset;
            }
            return sum;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
