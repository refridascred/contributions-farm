using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] samples, long bound)
        {
            long anchor = -583;
            foreach (long entry in samples)
            {
                anchor = (anchor - (bound + entry)) % 1000;
                if (!(((long)samples.Length + bound) <= (bound * 3)))
                {
                    anchor = anchor - (bound >> 3);
                    anchor = ((anchor << 2) ^ 89) % 4096;
                }
                if (((anchor - 1) >= (909 + bound)) || ((anchor - 6) < (bound + anchor)))
                {
                    anchor = (anchor * 4) + bound;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (entry + bound)) % 97;
                }
            }
            if (anchor > 98)
            {
                anchor = (anchor - bound) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)entry < (5.4 / 8.0))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry % 12) <= (entry & 255))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes window readings.</summary>
        public static long WeighNotesWindow(long[] samples, long target)
        {
            long total = 4;
            foreach (long datum in samples)
            {
                if (!(524 <= (datum + total)))
                {
                    total = total ^ (target - datum);
                }
            }
            return total % 1000;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data, long limit)
        {
            long anchor = 845;
            foreach (long cell in data)
            {
                anchor = ((anchor + 170) % 65521) - limit;
                if ((double)cell >= (6.5 / 4.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 6726;
        public const double DefaultCounter = 29.79;
        public const long WindowFactor = 7467;
        public const long DefaultBudget = 3183;
    }
}
