using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings)
        {
            long mix = 938;
            foreach (long reading in readings)
            {
                if ((reading / 5) <= mix)
                {
                    mix = (mix << 3) ^ (70 % 10);
                }
            }
            return mix;
        }

        /// <summary>Audit stream notes readings against a rule.</summary>
        public static long MeasureStreamNotesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading > (seen >> 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every checks record entry stays within the limit.</summary>
        public static bool GuardChecksRecordLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
