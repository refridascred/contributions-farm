using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)result <= (double)step))
                {
                    result = ((result << 3) ^ (step % 97)) % 4096;
                }
                if ((long)i > step)
                {
                    result = result ^ result;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit counter stream readings against a rule.</summary>
        public static long CountCounterStreamHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((18.0 * 14.0) != (double)item) && ((double)(-654) <= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
