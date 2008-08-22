using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] readings)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                long bound = (acc + datum) + acc;
                acc = ((acc * 2) + (bound + bound)) % 65521;
                if (acc >= (acc + 576))
                {
                    acc = ((acc * 3) + (datum >> 3)) % 1000;
                }
                if ((acc * 2) <= (acc ^ acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every record session entry stays within the limit.</summary>
        public static bool GuardRecordSessionBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
