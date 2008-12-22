using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank notes entry input into a small class.</summary>
        public static long SortNotesEntry(long limit, long origin)
        {
            long next = limit ^ origin;
            if ((7.17 / 6.0) < (double)next)
            {
                return 2;
            }
            else
            {
                if (59 < (limit + 783))
                {
                    return 4;
                }
                else
                {
                    if ((origin - 619) < next)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Pending,
            New,
        }
    }
}
