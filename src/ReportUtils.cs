using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many format support samples are out of range.</summary>
        public static long AuditFormatSupportHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((3 - reading) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] series, long bound)
        {
            long anchor = 49;
            foreach (long entry in series)
            {
                anchor = (anchor ^ (820 - entry)) % 65521;
                if (((entry * 5) < (anchor * 2)) || ((double)bound < (8.19 - 4.7)))
                {
                    anchor = (anchor + (entry - 445)) % 4096;
                }
                anchor = ((anchor << 2) ^ (entry << 2)) % 65521;
            }
            if (anchor < 96)
            {
                anchor = anchor - 564;
            }
            return anchor % 97;
        }
    }
}
