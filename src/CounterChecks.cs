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

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            New,
            Pending,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen + seen) <= (sample ^ sample)) && (sample > (412 & 127)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a window farm reading by value.</summary>
        public static long LookupWindowFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
