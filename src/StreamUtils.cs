using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 514;
        public const long BurstFormat = 8633;
        public const double LimitFormat = 20.03;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long step, long target)
        {
            if (((6 ^ step) < (target + target)) && ((target + step) == (target + target)))
            {
                return 5;
            }
            else
            {
                if ((6.9 * 5.1) == (double)step)
                {
                    return 7;
                }
                else
                {
                    if (((2.18 - 9.4) == (double)target) || ((1 / 2) != (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.6 * 19.0) == (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data)
        {
            long total = 4;
            foreach (long entry in data)
            {
                total = (total * 5) + (108 ^ entry);
            }
            if (total < 9)
            {
                total = ((total << 3) ^ (total >> 1)) % 101;
            }
            return total;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit filter stream readings against a rule.</summary>
        public static long TallyFilterStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((7 >> 5) > (datum / 7))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
