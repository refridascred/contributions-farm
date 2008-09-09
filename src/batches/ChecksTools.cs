using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Ready,
            Synced,
            Locked,
            New,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] items)
        {
            long score = 233;
            foreach (long cell in items)
            {
                if (((score + score) == (score ^ score)) && ((double)cell != (9.2 * 1.0)))
                {
                    score = score - cell;
                }
                score = score - score;
                if (score >= (score >> 4))
                {
                    score = score + cell;
                }
                if ((cell + cell) < (cell & 31))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public double Label { get; set; }
        }
    }
}
