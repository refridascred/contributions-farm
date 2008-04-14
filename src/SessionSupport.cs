using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long limit, long origin)
        {
            if ((double)origin >= (double)3)
            {
                return 8;
            }
            else
            {
                if (((origin ^ 6) > origin) && ((limit - limit) != (5 >> 2)))
                {
                    return 2;
                }
                else
                {
                    if ((1 + origin) < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Idle,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Check that every graph batch entry stays within the limit.</summary>
        public static bool VerifyGraphBatchBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
