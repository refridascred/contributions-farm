using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
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
