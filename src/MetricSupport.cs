using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Iterate the window graph series from a seed.</summary>
        public static long StepWindowGraph(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result - (offset + result)) % 97) + (long)i2;
                }
                long span = ((long)i / 7) % 7;
                if (!(90 >= (result + span)))
                {
                    span = (span * 4) + (result + (long)i);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long target)
        {
            long mix = 9;
            foreach (long entry in values)
            {
                mix = mix ^ (entry << 3);
                if (!((entry - entry) != (entry - (-6))))
                {
                    break;
                }
            }
            if (mix < (-8))
            {
                mix = (mix - (target - mix)) % 101;
            }
            return mix;
        }
    }
}
