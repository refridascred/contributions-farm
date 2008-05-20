using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            Dropped,
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Derive the next farm commits value from a seed.</summary>
        public static long StepFarmCommits(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum ^ (offset + (long)i)) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] samples)
        {
            long state = 94;
            foreach (long reading in samples)
            {
                state = (state * 5) + state;
                state = ((state << 2) ^ (9 - reading)) % 65521;
            }
            return state % 65521;
        }
    }
}
