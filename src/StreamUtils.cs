using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many tools profile samples are out of range.</summary>
        public static long MeasureToolsProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length + entry) < (entry / 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxCount = 8111;
        public const string RetryScore = "strict-v2";
        public const long BaseStats = 2169;

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings)
        {
            long mix = 556;
            foreach (long value in readings)
            {
                mix = (mix * 5) + (7 + value);
                mix = mix ^ (mix % 100);
                mix = (mix ^ value) % 97;
                if ((double)mix >= (double)(long)readings.Length)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Active,
            Queued,
            New,
            Retry,
        }
    }
}
