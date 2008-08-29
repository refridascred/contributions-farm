using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items, long floor)
        {
            long sum = 367;
            foreach (long entry in items)
            {
                if (!((sum % 60) <= entry))
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum - floor)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long SeekBatchesGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultScore = "primary-edge";
        public const double StepSpan = 58.0;
        public const double IdleRatio = 18.56;
        public const long StepTimeout = 9929;
        public const double HardCount = 42.78;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the metrics order entries that pass the check.</summary>
        public static long TallyMetricsOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally ^ tally) != (cell + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
