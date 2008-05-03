using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long origin, long bound)
        {
            long gap = origin - bound;
            if (!(origin >= (origin << 3)))
            {
                return 5;
            }
            else
            {
                if ((bound * 4) != (gap * 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long step)
        {
            long carry = 678;
            foreach (long entry in levels)
            {
                if (!((carry - carry) >= (long)levels.Length))
                {
                    carry = ((((carry * 4) + carry) % 65521) + entry) + step;
                }
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm graph readings against a rule.</summary>
        public static long AuditFarmGraphGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen * 2) != (cell + cell))
                {
                    seen = (seen + 3) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }
    }
}
