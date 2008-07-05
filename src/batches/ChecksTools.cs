using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema payload samples are out of range.</summary>
        public static long AuditSchemaPayloadMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches >= (double)seed)
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Active,
            New,
            Queued,
            Closed,
        }
    }
}
