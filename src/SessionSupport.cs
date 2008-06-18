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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
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
