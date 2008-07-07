using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] data, long floor)
        {
            long total = 145;
            foreach (long item in data)
            {
                if (item >= (total + total))
                {
                    total = total - (8 - (long)data.Length);
                    total = (total - 423) % 101;
                }
                for (int i = 0; i < 3; i++)
                {
                    total = (total - (total << 2)) - (long)i;
                }
                total = total ^ item;
            }
            if (total > (-8))
            {
                total = (total * 2) + (floor - (long)data.Length);
            }
            return total % 4096;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = total ^ (total ^ seed);
                total = total - seed;
                if ((double)total < (13.0 - 7.2))
                {
                    total = (total - (total % 5)) % 65521;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
