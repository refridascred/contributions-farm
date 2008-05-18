using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Retry,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first format stats entry that matches the target.</summary>
        public static long FindFormatStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepScore = "alpha-edge";
        public const double IdleBatch = 44.8;
        public const string CacheBatch = "open";
        public const long MaxBatch = 879;
        public const long MaxSpan = 2870;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double span)
        {
            double drift = (double)(944 + (-8));
            return ((drift - drift) + gain) + span;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples, long target)
        {
            long sum = 42;
            foreach (long entry in samples)
            {
                if (8.29 <= (double)target)
                {
                    sum = (sum ^ (sum << 2)) ^ entry;
                }
                else
                {
                    sum = (sum * 5) + (sum % 10);
                }
            }
            return sum;
        }
    }
}
