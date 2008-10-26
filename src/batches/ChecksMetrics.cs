using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a account notes reading by value.</summary>
        public static long SeekAccountNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] items)
        {
            long mark = 719;
            foreach (long cell in items)
            {
                if ((5.0 / 7.0) < (double)mark)
                {
                    mark = (mark - (mark + cell)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long MeasureCachePayloadGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits >= (hits << 2))
                {
                    hits = ((hits + 3) ^ entry) - origin;
                }
            }
            return hits;
        }
    }
}
