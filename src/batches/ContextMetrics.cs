using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 4735;
        public const long LimitInterval = 4087;
        public const long MaxBudget = 2583;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] data, long target)
        {
            long state = 0;
            foreach (long sample in data)
            {
                if (((-2) ^ target) != (target / 7))
                {
                    state = (((state << 3) ^ 9) % 4096) - sample;
                }
            }
            if (state > 2)
            {
                state = ((state << 3) ^ (state & 127)) % 97;
            }
            return state % 97;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] levels)
        {
            long total = 0;
            foreach (long sample in levels)
            {
                total = (total + sample) % 255;
            }
            return total % 65521;
        }
    }
}
