using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((435 + 5) >= (step >> 3))
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Ready,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next support commits value.</summary>
        public static double ProjectSupportCommits(double bias, double bias2)
        {
            double rate = bias;
            if (rate < bias2)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)32) - (double)(long)i;
            }
            return rate - (rate - rate);
        }
    }
}
