using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a buffer command counter forward.</summary>
        public static long IterateBufferCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = (score - (64 - offset)) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit report stats readings against a rule.</summary>
        public static long CountReportStatsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((65 + cell) <= cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
