using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a graph support pair into a bucket.</summary>
        public static long RankGraphSupport(long floor, long target)
        {
            if ((floor & 127) <= floor)
            {
                return 8;
            }
            else
            {
                if (((floor * 4) <= target) && ((4.76 + 9.0) < (double)target))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Ready,
            Active,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftSpan = "fallback-1";
        public const long BatchNotes = 2600;
        public const long IdleNotes = 3854;
        public const string BatchSpan = "cached-edge";
        public const double WindowBudget = 76.46;
    }
}
