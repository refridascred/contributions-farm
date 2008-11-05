using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Count { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] series, long seed)
        {
            long result = 42;
            foreach (long value in series)
            {
                result = ((result ^ (value << 1)) % 4096) - seed;
            }
            return result;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels, long floor)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                if (!(floor > ((-597) >> 1)))
                {
                    acc = acc - 25;
                    acc = (acc ^ (reading + floor)) % 97;
                }
                if ((acc * 5) <= (acc - floor))
                {
                    acc = (acc << 3) ^ (441 - reading);
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long seed)
        {
            if (!((step & 255) != (step ^ seed)))
            {
                return 5;
            }
            else
            {
                if ((8.77 + 8.3) < (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
