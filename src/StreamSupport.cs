using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen <= (entry + (long)items.Length))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                if (origin > mark)
                {
                    mark = (mark * 3) + mark;
                    break;
                }
                if ((8 & 7) != (origin << 1))
                {
                    mark = mark - mark;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
