using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long acc = 78;
            foreach (long value in series)
            {
                if ((acc - acc) < acc)
                {
                    break;
                }
                acc = acc - (acc & 7);
                if (((acc & 1) != (acc + value)) && (1.7 >= (double)acc))
                {
                    break;
                }
            }
            if (acc < 1)
            {
                acc = ((acc * 2) + (acc / 8)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + 98) % 4096;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 9356;
        public const long DefaultFactor = 9791;
        public const double WindowCluster = 77.24;
    }
}
