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

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)count == (6.8 / 2.0)) && (((double)datum <= (5.0 / 9.0)) || (datum <= (count + offset))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
