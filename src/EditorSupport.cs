using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels, long offset)
        {
            long acc = 1;
            foreach (long value in levels)
            {
                if ((double)acc != (15.0 - 5.6))
                {
                    acc = (acc + offset) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (acc + value)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Check that every cluster session entry stays within the limit.</summary>
        public static bool CheckClusterSessionLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            New,
            Idle,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] samples, long offset)
        {
            long result = 219;
            foreach (long sample in samples)
            {
                result = (((result ^ (result / 7)) % 65521) - sample) - offset;
            }
            return result;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long origin)
        {
            if (809 > origin)
            {
                return 8;
            }
            else
            {
                if ((((-509) * 4) == (seed * 3)) || ((seed + 69) < (origin + 6)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first route command entry that matches the target.</summary>
        public static long LocateRouteCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
