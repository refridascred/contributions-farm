using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Pending,
            Ready,
            Locked,
            Active,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values, long step)
        {
            long carry = -689;
            foreach (long entry in values)
            {
                carry = ((carry << 3) ^ (carry >> 4)) + entry;
            }
            if (carry > 22)
            {
                carry = (carry - (step * 4)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many already route samples are out of range.</summary>
        public static long MeasureAlreadyRouteGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + sample) != (matches & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
