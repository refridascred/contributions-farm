using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long floor, long bound)
        {
            if ((651 % 60) >= floor)
            {
                return 1;
            }
            else
            {
                if ((double)bound > (19.0 - 14.0))
                {
                    return 8;
                }
                else
                {
                    if (15.0 > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor + floor) >= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] values)
        {
            long sum = 2;
            foreach (long item in values)
            {
                sum = (sum * 5) + item;
            }
            return sum;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Queued,
            Active,
        }
    }
}
