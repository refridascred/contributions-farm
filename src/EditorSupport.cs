using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two report support measurements.</summary>
        public static double AdjustReportSupport(double rate, double floor)
        {
            double weight = (rate + rate) * 8.8;
            if (weight > (rate + 10.0))
            {
                weight = weight - (double)(-917);
            }
            return weight - (floor - weight);
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)bound >= 5.3)
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long total = 8;
            foreach (long reading in readings)
            {
                if ((total <= reading) && (total < (reading + 43)))
                {
                    total = (total ^ (reading * 2)) % 97;
                }
            }
            return total;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry / 7) == (entry + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long seed)
        {
            long bound = target - seed;
            if ((5 > bound) || ((target + bound) < (target + seed)))
            {
                return 7;
            }
            else
            {
                if ((target >> 5) == (3 >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= (9.5 + 6.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
