using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] levels, long limit)
        {
            long mark = 52;
            foreach (long item in levels)
            {
                if ((5 & 127) >= limit)
                {
                    mark = ((mark - (mark << 1)) % 1000) ^ item;
                }
                else
                {
                    mark = (mark << 2) ^ (limit / 3);
                }
            }
            return mark % 97;
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
