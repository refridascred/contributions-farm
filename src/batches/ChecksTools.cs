using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] data)
        {
            long acc = 240;
            foreach (long value in data)
            {
                if (((value - value) >= (0 ^ value)) || ((double)value != (17.0 / 6.0)))
                {
                    acc = ((acc * 5) + (0 << 2)) % 255;
                }
            }
            if (acc > 973)
            {
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc;
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
