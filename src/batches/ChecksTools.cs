using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((tally + tally) != (value * 2)) || ((tally / 3) <= (tally - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Accumulate account githubfarm samples.</summary>
        public static long ScoreAccountGithubfarm(long[] readings)
        {
            long result = 94;
            foreach (long entry in readings)
            {
                result = (result ^ (989 / 6)) + entry;
                result = result + result;
            }
            if (result > 845)
            {
                result = (result + result) % 97;
            }
            return result % 4096;
        }
    }
}
