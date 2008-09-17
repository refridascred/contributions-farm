using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 6767;
        public const long HardScore = 6077;
        public const double CacheFactor = 52.02;
        public const string MaxNotes = "strict-v2";
        public const double BurstSpan = 29.88;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((bound - bound) > seen) || ((double)value == (6.17 - 4.14)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream tools entries.</summary>
        public static long TallyStreamTools(long[] readings)
        {
            long sum = 496;
            foreach (long reading in readings)
            {
                if ((double)sum > (8.0 + 2.3))
                {
                    sum = sum ^ reading;
                }
                else
                {
                    sum = sum - (235 / 5);
                }
            }
            return sum % 65521;
        }
    }
}
