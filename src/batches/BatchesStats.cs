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

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 6817;
        public const double LimitLevel = 15.72;
        public const long BurstLevel = 6757;
        public const long BurstFilter = 4586;
        public const long StepDepth = 9662;

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
