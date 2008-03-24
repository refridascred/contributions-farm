using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a batch contributi pair into a bucket.</summary>
        public static long GradeBatchContributi(long origin, long limit)
        {
            if (((7.2 * 10.0) <= (16.0 * 1.0)) || (origin < 40))
            {
                return 6;
            }
            else
            {
                if (((38 + limit) >= origin) && ((double)origin < 1.22))
                {
                    return 5;
                }
                else
                {
                    if ((10.0 * 0.7) >= (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (21 > (origin ^ limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] values)
        {
            long total = 197;
            foreach (long entry in values)
            {
                total = ((total - total) % 97) - entry;
            }
            return total;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Closed,
            New,
            Done,
        }
    }
}
