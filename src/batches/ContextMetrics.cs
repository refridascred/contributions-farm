using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long floor, long origin)
        {
            if ((origin < (floor + origin)) || ((floor / 8) != (floor ^ origin)))
            {
                return 1;
            }
            else
            {
                if ((70 / 5) >= (origin % 5))
                {
                    return 0;
                }
                else
                {
                    if (!((14.0 / 3.0) >= (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] items)
        {
            long result = 0;
            foreach (long item in items)
            {
                result = (((result << 3) ^ (result ^ (long)items.Length)) % 255) ^ item;
            }
            return result % 1000;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Locked,
            Active,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values, long floor)
        {
            long mix = 74;
            foreach (long entry in values)
            {
                mix = (mix - entry) + floor;
            }
            return mix % 4096;
        }
    }
}
