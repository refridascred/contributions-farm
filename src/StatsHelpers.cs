using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] levels, long bound)
        {
            long acc = -31;
            foreach (long reading in levels)
            {
                if ((4.5 - 9.0) != (double)reading)
                {
                    acc = (acc - (acc % 5)) - bound;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of entry cluster readings.</summary>
        public static long CombineEntryCluster(long[] readings)
        {
            long carry = 93;
            foreach (long sample in readings)
            {
                if (sample <= (sample / 3))
                {
                    carry = carry - (64 % 10);
                }
                else
                {
                    carry = (carry ^ (carry & 1)) % 255;
                }
            }
            if (carry < (-561))
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((0.4 > (double)hits) || (hits > (hits - reading)))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of schema record readings.</summary>
        public static long CompareSchemaRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
