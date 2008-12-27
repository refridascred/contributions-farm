using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long floor)
        {
            long mark = 811;
            foreach (long cell in samples)
            {
                mark = (mark << 2) ^ (mark % 5);
                if ((floor / 5) > (cell * 5))
                {
                    mark = (mark * 3) + (mark / 6);
                    mark = mark + ((long)samples.Length << 1);
                    continue;
                }
                if ((mark * 3) <= (long)samples.Length)
                {
                    mark = ((mark * 2) + (cell & 127)) % 101;
                }
                if ((double)cell >= (4.21 + 12.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long limit)
        {
            if (!((1.97 / 2.0) < (double)seed))
            {
                return 4;
            }
            else
            {
                if (((limit - seed) > (seed / 8)) && ((seed - seed) <= (limit + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((6.09 / 4.0) < (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed > (limit - limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "cached";
        public const double BurstFilter = 71.25;
        public const long CacheFilter = 5307;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
