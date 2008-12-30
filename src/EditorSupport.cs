using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)7 >= (double)bound)
                {
                    carry = (carry << 3) ^ (carry & 255);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every checks entry entry stays within the limit.</summary>
        public static bool GuardChecksEntryLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Closed,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(((double)count < 7.0) && ((count + datum) >= (datum & 127))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
