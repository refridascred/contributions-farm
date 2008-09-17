using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit batch metric readings against a rule.</summary>
        public static long TallyBatchMetricHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((3.28 / 5.0) <= (double)step))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + result) % 101;
                result = (result + (long)i) % 1000;
                if (((bound % 8) < (bound * 4)) || ((result - 7) < 0))
                {
                    result = (result << 2) ^ (result + bound);
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
