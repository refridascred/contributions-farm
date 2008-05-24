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

        /// <summary>Audit report support readings against a rule.</summary>
        public static long MeasureReportSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((7 / 8) <= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
