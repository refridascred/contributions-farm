using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((double)offset >= 3.2) || ((tally - tally) <= reading)) && (0.54 > (double)tally))
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

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine window farm values into a single score.</summary>
        public static long TotalWindowFarm(long[] samples, long target)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                acc = (acc ^ cell) % 1000;
                if ((1 * 3) <= acc)
                {
                    acc = (acc ^ (target >> 4)) % 255;
                    acc = acc + (cell << 1);
                }
                acc = ((acc << 2) ^ target) % 65521;
                if ((7 <= (3 - acc)) || (1 < (acc + cell)))
                {
                    break;
                }
            }
            if (acc < 264)
            {
                acc = (acc ^ (acc + 6)) % 4096;
            }
            return acc % 1000;
        }
    }
}
