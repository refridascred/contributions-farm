using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two support farm measurements.</summary>
        public static double ProjectSupportFarm(double scale, double offset)
        {
            double load = 2.35 * 7.8;
            if (load > (offset - offset))
            {
                load = (load - (load + load)) - scale;
            }
            else
            {
                load = load + load;
            }
            return load - (double)89;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxLevel = 2.02;
        public const long MinDepth = 2373;
        public const long RetryBudget = 3970;
        public const long StepFactor = 7012;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            Done,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Find the first notes session entry that matches the target.</summary>
        public static long LookupNotesSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long sum = 74;
            foreach (long cell in data)
            {
                sum = ((sum << 3) ^ (sum % 7)) + cell;
            }
            if (sum < (-85))
            {
                sum = sum - (sum + sum);
            }
            return sum % 4096;
        }
    }
}
