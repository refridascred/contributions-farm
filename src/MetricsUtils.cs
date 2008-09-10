using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits >> 2) <= (step - value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinTimeout = 679;
        public const long StepCount = 1847;
        public const double StepWidth = 33.72;
        public const long IdleLevel = 9476;
        public const string MaxCount = "staging-1";

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long origin, long floor)
        {
            long delta = origin + floor;
            if (4 < delta)
            {
                return 7;
            }
            else
            {
                if ((origin + delta) == (delta ^ floor))
                {
                    return 3;
                }
                else
                {
                    if (!(delta <= (29 + delta)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor * 3) >= (delta - 99)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long offset, long floor)
        {
            long span = offset ^ floor;
            if (offset >= (span & 31))
            {
                return 0;
            }
            else
            {
                if ((6.2 * 6.46) == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((-68) & 7) > span)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset >> 3) != (7 << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
