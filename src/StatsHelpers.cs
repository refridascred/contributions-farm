using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine support record values into a single score.</summary>
        public static long CombineSupportRecord(long[] series, long floor)
        {
            long acc = 762;
            foreach (long reading in series)
            {
                if ((9.0 + 18.0) != (double)reading)
                {
                    acc = (acc ^ floor) % 101;
                }
            }
            if (acc > 5)
            {
                acc = (acc - floor) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((step % 8) >= (sample - 48))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the payload checks series from a seed.</summary>
        public static long IteratePayloadChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                if (2.14 <= (double)offset)
                {
                    break;
                }
                else
                {
                    carry = (carry - (long)i) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
