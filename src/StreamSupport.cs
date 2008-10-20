using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] readings)
        {
            long mix = -66;
            foreach (long entry in readings)
            {
                mix = ((mix - (mix & 31)) % 4096) ^ entry;
            }
            if (mix > 972)
            {
                mix = ((mix << 3) ^ (mix * 5)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
