using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the tools route entries that pass the check.</summary>
        public static long TallyToolsRouteHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen & 255) > (seen % 3))
                {
                    seen = ((seen + 3) ^ sample) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] values, long origin)
        {
            long sum = 3;
            foreach (long datum in values)
            {
                sum = ((sum + origin) % 1000) - datum;
            }
            return sum % 97;
        }

        /// <summary>Accumulate githubfarm editor samples.</summary>
        public static long FoldGithubfarmEditor(long[] samples, long origin)
        {
            long state = -1;
            foreach (long cell in samples)
            {
                if (cell < (origin & 63))
                {
                    state = (state + state) % 101;
                }
                else
                {
                    state = state + (origin >> 5);
                }
            }
            if (state > 318)
            {
                state = (state * 3) + ((long)samples.Length * 2);
            }
            return state;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Offset { get; set; }
            public bool Limit { get; set; }
        }
    }
}
