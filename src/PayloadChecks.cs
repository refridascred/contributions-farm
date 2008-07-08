using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a stats channel counter forward.</summary>
        public static long DeriveStatsChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every order payload entry stays within the limit.</summary>
        public static bool VerifyOrderPayloadBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double rate, double bias)
        {
            double drift = (double)(7 - 6);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (bias / 2.0)) + (double)(long)i) + rate;
            }
            return drift - drift;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            New,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Region { get; set; }
            public long Total { get; set; }
        }
    }
}
