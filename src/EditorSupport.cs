using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 43.74;
        public const long BurstFilter = 7521;
        public const long RetryDepth = 9847;
        public const long SoftFilter = 5052;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 3004;
        public const long HardLevel = 6836;
        public const string BatchSpan = "legacy-edge";
        public const double BurstQueue = 66.22;

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long floor)
        {
            if (((5.28 / 5.0) == (double)floor) && (seed > (seed + floor)))
            {
                return 4;
            }
            else
            {
                if ((floor >= (9 - floor)) && ((7.72 / 5.0) >= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (((floor & 127) > floor) && (seed <= (964 + floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
