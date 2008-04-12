using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally >= (tally + value))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }
    }
}
