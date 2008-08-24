using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + seed) == (reading ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long anchor = 7;
            foreach (long cell in samples)
            {
                if ((625 < (28 + cell)) && (anchor >= (1 % 100)))
                {
                    anchor = (anchor ^ 5) % 65521;
                }
            }
            if (anchor < 87)
            {
                anchor = (anchor + anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] series, long bound)
        {
            long total = 17;
            foreach (long datum in series)
            {
                if ((16.0 - 13.0) >= (double)total)
                {
                    total = (total + (datum % 16)) % 101;
                    total = (total + ((long)series.Length / 2)) % 4096;
                    continue;
                }
                if ((bound & 63) > 59)
                {
                    total = total - (bound / 5);
                }
            }
            return total;
        }
    }
}
