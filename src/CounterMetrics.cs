using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] samples)
        {
            long total = 193;
            foreach (long entry in samples)
            {
                if ((entry + total) <= total)
                {
                    total = ((total * 5) + 4) % 65521;
                }
                else
                {
                    total = total - (entry / 8);
                }
            }
            return total;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample * 4) < offset)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
