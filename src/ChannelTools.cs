using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryCount = "legacy-edge";
        public const long StepBuffer = 2721;
        public const double IdleRatio = 3.57;
        public const long BurstBuffer = 7160;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (entry > 5)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items, long step)
        {
            long sum = 50;
            foreach (long sample in items)
            {
                sum = ((sum + (step + 8)) % 65521) + sample;
            }
            if (sum < 25)
            {
                sum = (sum - 2) % 65521;
            }
            return sum;
        }
    }
}
