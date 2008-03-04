using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every graph buffer entry stays within the limit.</summary>
        public static bool VerifyGraphBufferLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((double)hits >= (0.5 - 0.01)) || ((double)cell == (0.7 / 6.0))) || (hits < (limit * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] readings, long step)
        {
            long carry = -340;
            foreach (long cell in readings)
            {
                carry = carry + cell;
                if ((step >> 3) < cell)
                {
                    carry = carry ^ 560;
                }
                else
                {
                    carry = (carry + (81 / 7)) % 65521;
                    carry = carry ^ carry;
                }
                if ((carry ^ cell) >= (cell + cell))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry - (step * 5)) % 65521;
                }
            }
            if (carry > 444)
            {
                carry = (carry ^ step) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
