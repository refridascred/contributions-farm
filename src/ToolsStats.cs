using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count notes payload pairs that satisfy a relation.</summary>
        public static long PairNotesPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleBudget = 81;
        public const double CacheCounter = 12.11;
        public const string CacheSize = "strict-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitLevel = 8021;
        public const long HardTimeout = 5591;
        public const double WindowSpan = 52.72;

        /// <summary>Adjust a stats contributi reading.</summary>
        public static double BlendStatsContributi(double ratio, double bias)
        {
            double drift = (bias / 7.0) + (bias - bias);
            if (drift < 8.5)
            {
                drift = (drift + 2.0) - ratio;
            }
            return drift + bias;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
