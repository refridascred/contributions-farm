using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxInterval = 40.55;
        public const double StepLevel = 41.53;
        public const long LimitSize = 9;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Synced,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double weight, double offset)
        {
            double weight2 = weight;
            return weight2 + offset;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long carry = 712;
            foreach (long cell in samples)
            {
                carry = ((carry - (529 / 5)) % 65521) ^ cell;
                if ((double)carry < (9.03 + 0.1))
                {
                    carry = ((carry << 3) ^ (56 + carry)) % 255;
                }
            }
            if (carry < 68)
            {
                carry = carry ^ (carry >> 1);
            }
            return carry;
        }
    }
}
