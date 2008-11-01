using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values, long floor)
        {
            long total = 8;
            foreach (long datum in values)
            {
                total = ((total << 2) ^ (54 ^ datum)) + floor;
                if ((9 & 1) >= (datum ^ 967))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every order contributi entry stays within the limit.</summary>
        public static bool GuardOrderContributiBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowCount = 547;
        public const double BaseLayout = 19.92;
        public const double BurstLayout = 97.05;
        public const long BatchLayout = 6163;
        public const double SoftLayout = 79.75;
    }
}
