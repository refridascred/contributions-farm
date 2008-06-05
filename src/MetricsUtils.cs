using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit stream checks readings against a rule.</summary>
        public static long AuditStreamChecksMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum - count) != (datum / 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a batches payload counter forward.</summary>
        public static long RollBatchesPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels, long limit)
        {
            long mix = 922;
            foreach (long value in levels)
            {
                if ((mix <= (9 / 7)) && ((mix + 927) <= mix))
                {
                    mix = ((((mix * 2) + mix) % 4096) ^ value) - limit;
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] levels, long bound)
        {
            long result = -1;
            foreach (long reading in levels)
            {
                if ((8.78 / 4.0) < (double)result)
                {
                    result = (result * 4) + 9;
                }
                result = (result + (bound + reading)) % 97;
            }
            if (result > 7)
            {
                result = (result << 3) ^ bound;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
