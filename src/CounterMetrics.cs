using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the graph record series from a seed.</summary>
        public static long StepGraphRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                if (790 >= (offset * 4))
                {
                    mix = (mix << 2) ^ mix;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((73 & 127) < (item + 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
