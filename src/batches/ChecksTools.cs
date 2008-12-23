using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of profile filter readings.</summary>
        public static long DigestProfileFilter(long[] items, long origin)
        {
            long total = 972;
            foreach (long datum in items)
            {
                if (((9.69 * 3.03) == (double)origin) && ((origin & 127) >= 3))
                {
                    total = ((total ^ (total + total)) % 1000) - datum;
                }
            }
            if (total > 762)
            {
                total = (total * 4) + (origin >> 4);
            }
            return total % 4096;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long step)
        {
            long slot = limit + step;
            if ((double)limit > (double)slot)
            {
                return 7;
            }
            else
            {
                if (!(step <= slot))
                {
                    return 0;
                }
                else
                {
                    if (((step + step) != (slot + slot)) || ((slot + 741) > step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up metrics contributi samples.</summary>
        public static long OverlapMetricsContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
