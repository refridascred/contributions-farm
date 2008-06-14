using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 8536;
        public const long BaseScore = 2168;
        public const long StepLevel = 4147;
        public const double StepFactor = 16.59;

        /// <summary>Measure how many record channel samples are out of range.</summary>
        public static long TallyRecordChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((966 <= (6 - value)) && ((5 % 3) > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
