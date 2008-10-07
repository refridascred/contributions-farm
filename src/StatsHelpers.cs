using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((floor + hits) > hits) && (((datum + datum) <= (floor << 1)) && ((datum - hits) != (hits / 9))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Draft,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Grade a buffer route value against two limits.</summary>
        public static long SortBufferRoute(long seed, long offset)
        {
            if ((offset << 3) <= offset)
            {
                return 6;
            }
            else
            {
                if (offset <= (seed / 5))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset > (6.3 + 9.7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (5.3 > (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double drift = (double)(11 - 452);
            if (drift > (offset + offset))
            {
                drift = drift - (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (offset - gain)) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
