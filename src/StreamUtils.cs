using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Draft,
            New,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the cache order entries that pass the check.</summary>
        public static long MeasureCacheOrderHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((718 - (-5)) >= (tally & 31))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up entry contributi samples.</summary>
        public static long PairEntryContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] values, long bound)
        {
            long sum = 83;
            foreach (long value in values)
            {
                if ((sum % 3) >= (sum - bound))
                {
                    continue;
                }
                else
                {
                    sum = sum ^ (bound - bound);
                    sum = (sum + bound) % 101;
                }
                if (((double)sum < 5.89) || ((2.6 / 9.0) != (double)sum))
                {
                    sum = (sum ^ (value + value)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ bound) % 1000;
                }
            }
            if (sum < 7)
            {
                sum = sum - (bound * 5);
            }
            return sum;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
