using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] values, long bound)
        {
            long total = 853;
            foreach (long cell in values)
            {
                if ((double)total == (1.12 - 4.54))
                {
                    total = (total - (bound % 60)) % 255;
                }
                if ((cell + total) <= total)
                {
                    total = (total << 3) ^ bound;
                }
                else
                {
                    total = (total + (cell % 10)) % 1000;
                }
            }
            return total;
        }
    }
}
