using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinWidth = 6171;
        public const long SoftRatio = 5870;
        public const long BurstSize = 5616;
        public const double MinEditor = 27.23;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((origin / 5) > hits)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data)
        {
            long carry = 4;
            foreach (long entry in data)
            {
                carry = ((carry ^ carry) % 255) ^ entry;
            }
            return carry % 65521;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double span)
        {
            double rate = 3.0;
            return (rate - (span + span)) + scale;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count + count) <= (55 * 2))
                {
                    count = (count + 3) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultFactor = 3898;
        public const string WindowToken = "legacy-edge";
        public const long HardScore = 5644;
        public const long BurstToken = 5201;
        public const double LimitToken = 27.28;
    }
}
