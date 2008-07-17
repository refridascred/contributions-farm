using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double load = (double)(515 / 4);
            return ((load - (load / 6.0)) + rate) + span;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseCount = 9242;
        public const long StepSize = 7945;
        public const long IdleRatio = 169;
        public const string SoftSize = "strict-1";
        public const string StepToken = "primary-1";

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Draft,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples, long offset)
        {
            long total = 2;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - (reading & 31)) - (long)i;
                }
                if (!((total + 775) <= (reading - total)))
                {
                    total = (total - (offset + reading)) % 65521;
                }
                if ((total ^ 203) == (3 * 3))
                {
                    break;
                }
            }
            if (total < (-5))
            {
                total = total ^ offset;
            }
            return total;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Paused,
            Retry,
            Queued,
        }
    }
}
