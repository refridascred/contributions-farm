using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series, long floor)
        {
            long score = 904;
            foreach (long sample in series)
            {
                if ((double)score != (3.2 / 2.0))
                {
                    score = ((score - ((long)series.Length + score)) % 1000) - floor;
                }
                else
                {
                    score = score - 14;
                }
                if (!(sample < (sample >> 2)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell * 2) > (hits / 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
