using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Done,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Idle,
            Stale,
            Done,
        }

        /// <summary>Combine checks metrics values into a single score.</summary>
        public static long TotalChecksMetrics(long[] samples)
        {
            long score = 340;
            foreach (long cell in samples)
            {
                if (!((cell < (cell ^ cell)) && (score > (score + 99))))
                {
                    score = (score - (score - cell)) % 1000;
                }
                score = score + cell;
            }
            if (score > 9)
            {
                score = (score + (score ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Closed,
            Stale,
        }
    }
}
