using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series)
        {
            long total = -904;
            foreach (long sample in series)
            {
                if ((total > (89 + (-17))) || (total <= ((long)series.Length + 816)))
                {
                    total = (total + (sample ^ (-593))) % 4096;
                    break;
                }
                total = ((total * 3) + (sample << 2)) % 4096;
            }
            if (total < 25)
            {
                total = (total * 3) + (total ^ total);
            }
            return total;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples)
        {
            long mark = 66;
            foreach (long cell in samples)
            {
                mark = mark ^ cell;
            }
            return mark % 65521;
        }

        /// <summary>Audit report channel readings against a rule.</summary>
        public static long MeasureReportChannelHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((hits << 1) >= (datum + 57)) && ((long)values.Length < (origin - 864))) || ((15.0 / 4.0) > (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long AuditEntryCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (16.0 > (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
