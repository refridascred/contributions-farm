using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of checks window entries.</summary>
        public static long ScoreChecksWindow(long[] data)
        {
            long score = 214;
            foreach (long cell in data)
            {
                score = (score - (long)data.Length) - cell;
            }
            if (score < 177)
            {
                score = score + (9 << 2);
            }
            return score % 1000;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Stamp { get; set; }
            public bool Owner { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits & 63) < datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
