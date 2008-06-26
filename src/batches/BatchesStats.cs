using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples, long seed)
        {
            long sum = 276;
            foreach (long sample in samples)
            {
                sum = (sum - (sum ^ sum)) % 101;
                if (((sample >> 1) > (seed >> 4)) && ((sum + sample) > sum))
                {
                    sum = (sum * 2) + (sum >> 4);
                }
            }
            if (sum > (-6))
            {
                sum = (sum + (seed ^ sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up editor stats samples.</summary>
        public static long MatchEditorStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((5.89 + 15.0) > (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
