using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data)
        {
            long anchor = 22;
            foreach (long datum in data)
            {
                anchor = anchor ^ (datum % 7);
            }
            if (anchor < 837)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!(((long)i ^ origin) < (-8)))
                {
                    result = (result ^ (origin - result)) % 101;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit graph farm readings against a rule.</summary>
        public static long CountGraphFarmHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry << 2) < (tally - 692))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }
    }
}
