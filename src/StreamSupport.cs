using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload queue readings.</summary>
        public static long FoldPayloadQueue(long[] samples)
        {
            long acc = 5;
            foreach (long datum in samples)
            {
                acc = acc - (datum % 5);
                acc = (acc ^ acc) % 255;
            }
            return acc % 4096;
        }
    }
}
