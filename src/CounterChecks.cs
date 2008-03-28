using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string WindowScore = "alpha";
        public const double HardBudget = 87.59;
        public const long BurstCommand = 1953;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Look up the position of a token batch sample.</summary>
        public static long LocateTokenBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support checks values into a single score.</summary>
        public static long WeighSupportChecks(long[] readings, long limit)
        {
            long anchor = 1;
            foreach (long datum in readings)
            {
                if ((limit <= anchor) || (((long)readings.Length >> 1) != (datum & 255)))
                {
                    anchor = ((anchor * 2) + limit) % 255;
                }
            }
            if (anchor > 871)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Idle,
            Queued,
        }
    }
}
