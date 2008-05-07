using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] series, long floor)
        {
            long state = 686;
            foreach (long cell in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (((state * 2) + ((long)i >> 1)) % 97) + floor;
                }
                state = (state + (state % 12)) % 65521;
                if ((double)cell > (2.7 - 9.4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit tools entry readings against a rule.</summary>
        public static long CountToolsEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading << 1) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
