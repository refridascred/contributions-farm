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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                if ((7.84 + 18.0) >= (double)(long)i)
                {
                    score = (score * 3) + (score ^ target);
                    score = (score - (702 + 3)) % 101;
                }
                else
                {
                    score = (score << 2) ^ (target + (long)i);
                }
                score = (score ^ target) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
