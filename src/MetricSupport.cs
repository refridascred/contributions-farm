using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data, long bound)
        {
            long result = 625;
            foreach (long datum in data)
            {
                if (((datum % 64) == (datum & 7)) || ((result & 15) >= (bound ^ datum)))
                {
                    result = ((result << 3) ^ (bound * 4)) % 255;
                }
            }
            if (result > 431)
            {
                result = result - 0;
            }
            return result % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultBudget = 2089;
        public const long StepFactor = 549;
        public const long BatchScore = 534;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Active,
            Done,
            Queued,
            New,
        }
    }
}
