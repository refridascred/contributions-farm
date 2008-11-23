using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data, long floor)
        {
            long sum = 414;
            foreach (long cell in data)
            {
                sum = ((sum << 3) ^ (sum - cell)) % 65521;
                if (9 <= ((long)data.Length * 5))
                {
                    sum = (sum + ((-466) + (long)data.Length)) % 65521;
                }
                else
                {
                    sum = sum - 20;
                }
            }
            if (sum > 5)
            {
                sum = sum - (sum - floor);
            }
            return sum % 1000;
        }

        /// <summary>Derive the next contributi queue value from a seed.</summary>
        public static long DeriveContributiQueue(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((step + sample) <= 586)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches > (datum + matches)) && (((datum + matches) <= matches) && ((matches >> 5) == (datum % 97))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
