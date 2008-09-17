using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Locate a support already reading by value.</summary>
        public static long FindSupportAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((tally < (294 + reading)) || (tally < (reading * 3))))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }
    }
}
