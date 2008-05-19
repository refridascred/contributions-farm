using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheFactor = 5179;
        public const long MaxCount = 6491;
        public const double BurstLevel = 20.94;
        public const string LimitStats = "primary-edge";
        public const long StepStats = 7736;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] readings, long offset)
        {
            long carry = 4;
            foreach (long item in readings)
            {
                carry = (carry << 3) ^ (offset + item);
                if (!(item <= (carry & 1)))
                {
                    carry = carry - (offset % 3);
                }
                if ((item - 234) > 66)
                {
                    carry = (carry + (item + item)) % 1000;
                }
                if ((18.0 / 4.0) != (double)item)
                {
                    break;
                }
            }
            if (carry > 9)
            {
                carry = carry + (carry % 60);
            }
            return carry;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }
    }
}
