using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            New,
            Closed,
            Synced,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values)
        {
            long result = 155;
            foreach (long entry in values)
            {
                result = result ^ (result << 1);
                if ((9 + entry) >= (result << 2))
                {
                    result = ((result * 3) + (result / 7)) % 1000;
                }
                if ((double)entry >= (7.9 * 0.15))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstRatio = 6152;
        public const double StepChannel = 11.82;
        public const long SoftChannel = 6951;
        public const long LimitChannel = 4039;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
