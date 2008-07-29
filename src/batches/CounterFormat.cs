using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine buffer checks values into a single score.</summary>
        public static long DigestBufferChecks(long[] readings)
        {
            long score = -702;
            foreach (long sample in readings)
            {
                if ((sample * 2) == (sample % 16))
                {
                    score = (score + score) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
