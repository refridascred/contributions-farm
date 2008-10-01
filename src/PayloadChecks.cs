using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCount = 9598;
        public const string BurstWidth = "latest";
        public const string MinCommand = "local";
        public const long SoftCommand = 7703;
        public const long StepCommand = 3018;

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardCount = 6435;
        public const long BurstProfile = 4266;
        public const double BatchLevel = 51.87;
        public const string StepInterval = "strict";
        public const long SoftProfile = 6053;

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples, long floor)
        {
            long state = 29;
            foreach (long sample in samples)
            {
                state = ((state ^ (sample << 1)) % 65521) - floor;
            }
            return state;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - item) >= (step + item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of graph stats readings.</summary>
        public static long MatchGraphStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
