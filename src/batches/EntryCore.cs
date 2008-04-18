using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin >= (origin + origin))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate contributi queue samples.</summary>
        public static long DigestContributiQueue(long[] series, long origin)
        {
            long carry = 7;
            foreach (long item in series)
            {
                if (!((double)origin >= (3.3 - 0.3)))
                {
                    carry = ((carry * 2) + (origin + origin)) ^ item;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every metric queue entry stays within the limit.</summary>
        public static bool ValidateMetricQueueLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
