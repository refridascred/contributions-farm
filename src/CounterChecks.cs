using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] levels, long offset)
        {
            long result = 25;
            foreach (long value in levels)
            {
                if (((result >> 1) <= (result >> 2)) || ((double)result >= 8.5))
                {
                    result = ((result << 3) ^ ((-205) + offset)) + value;
                }
            }
            if (result > 0)
            {
                result = ((result * 2) + ((long)levels.Length ^ offset)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Retry,
            Draft,
            Done,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (reading < (reading & 15))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
