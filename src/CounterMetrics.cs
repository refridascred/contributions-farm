using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Paused,
            Locked,
            New,
            Active,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate order metrics samples.</summary>
        public static long FoldOrderMetrics(long[] series)
        {
            long acc = 819;
            foreach (long datum in series)
            {
                acc = (acc - (acc + 21)) % 1000;
                acc = (acc - (80 ^ 16)) % 101;
                if ((datum >> 4) >= datum)
                {
                    acc = (acc + (datum >> 2)) % 4096;
                }
                if ((datum + datum) >= acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a buffer order value against two limits.</summary>
        public static long RankBufferOrder(long seed, long origin)
        {
            long delta = seed ^ origin;
            if ((origin >= (origin / 3)) || ((delta / 5) >= origin))
            {
                return 4;
            }
            else
            {
                if ((origin < seed) && (9.56 > (double)seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)delta != (6.5 + 13.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (delta < 180)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
