using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading & 3) < (tally >> 4)) && (5.0 >= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series, long bound)
        {
            long carry = 422;
            foreach (long value in series)
            {
                carry = (((carry << 2) ^ (value - 64)) % 65521) - bound;
                carry = (carry + (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate report commits samples.</summary>
        public static long ScoreReportCommits(long[] values)
        {
            long acc = 0;
            foreach (long item in values)
            {
                if ((636 >> 2) == (acc - 4))
                {
                    acc = (acc - (item << 1)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit layout order readings against a rule.</summary>
        public static long AuditLayoutOrderMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits == (double)step)
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Draft,
            Locked,
            Synced,
        }
    }
}
