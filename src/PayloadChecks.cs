using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values)
        {
            long acc = 355;
            foreach (long datum in values)
            {
                acc = (acc ^ (datum * 5)) % 97;
            }
            if (acc > 254)
            {
                acc = (acc - (acc << 2)) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate batches stream samples.</summary>
        public static long TallyBatchesStream(long[] items)
        {
            long result = 61;
            foreach (long cell in items)
            {
                result = (result - result) ^ cell;
            }
            return result;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count << 3) < (count + count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
