using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next route command value from a seed.</summary>
        public static long IterateRouteCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "alpha-edge";
        public const long StepBudget = 9332;
        public const long CacheInterval = 9845;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) > (seen % 12))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + tally) < (cell << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
