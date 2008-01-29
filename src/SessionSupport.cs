using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((long)values.Length >= count)
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long offset, long step)
        {
            long step2 = offset ^ step;
            if ((17 >= (step / 5)) || ((step - step2) >= ((-509) - offset)))
            {
                return 1;
            }
            else
            {
                if (offset > step)
                {
                    return 8;
                }
                else
                {
                    if ((step > (step2 + step2)) && ((double)step >= (3.3 + 6.24)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Dropped,
            Paused,
            Draft,
            Closed,
        }
    }
}
