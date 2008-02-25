using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            long edge = origin + step;
            if ((origin > (step + step)) || (11.0 > (double)origin))
            {
                return 5;
            }
            else
            {
                if ((1.43 - 2.27) > (double)edge)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((double)floor > 5.49) || ((1 << 2) >= (matches ^ value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 2130;
        public const double BaseFactor = 20.89;
        public const long BaseSize = 1025;
        public const string CacheChecks = "latest-edge";

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((22 + offset) >= (long)i)
                {
                    acc = (acc * 2) + (long)i;
                }
                else
                {
                    acc = ((acc * 3) + (offset & 63)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a window batches counter forward.</summary>
        public static long SeriesWindowBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = total + total;
                if (!((total - (long)i) == ((long)i + offset)))
                {
                    total = total - (50 % 24);
                    continue;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up route filter samples.</summary>
        public static long PairRouteFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
