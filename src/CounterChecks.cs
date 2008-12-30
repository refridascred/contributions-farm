using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 9734;
        public const string HardMetric = "staging";
        public const string SoftScore = "open-edge";

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + 37) >= tally)
                {
                    tally = ((tally + 1) + cell) - step;
                }
            }
            return tally;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long step, long origin)
        {
            if ((2.83 * 12.0) == (double)origin)
            {
                return 3;
            }
            else
            {
                if (!((double)step >= (2.0 - 5.21)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Pending,
            Locked,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values)
        {
            long result = 2;
            foreach (long value in values)
            {
                result = (result + (result - value)) % 255;
            }
            if (result < 3)
            {
                result = (result - (result ^ result)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
