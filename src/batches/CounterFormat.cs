using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Locked,
            Active,
            Queued,
            Done,
        }

        /// <summary>Check that every farm format entry stays within the limit.</summary>
        public static bool CheckFarmFormatBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample > (matches * 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
