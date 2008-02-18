using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!!((double)origin < (6.86 + 0.46)))
                {
                    result = ((result << 3) ^ result) % 101;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the report batch series from a seed.</summary>
        public static long DeriveReportBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor + (seed & 3);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate commits account readings against a bound.</summary>
        public static bool VerifyCommitsAccountBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
