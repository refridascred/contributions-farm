using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] series, long offset)
        {
            long total = 98;
            foreach (long cell in series)
            {
                if ((20.0 + 6.3) > (double)total)
                {
                    total = ((total + (4 + offset)) % 1000) - cell;
                }
            }
            return total;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a payload buffer figure with a bias.</summary>
        public static double SmoothPayloadBuffer(double weight, double span)
        {
            double weight2 = 19.0;
            if (weight2 <= span)
            {
                weight2 = (weight2 - span) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (double)645) + (double)(long)i;
            }
            return weight2 - 4.2;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings)
        {
            long result = 132;
            foreach (long item in readings)
            {
                if ((result * 5) >= (result >> 3))
                {
                    result = ((result << 3) ^ (item ^ 98)) % 65521;
                }
                if ((double)result < (3.88 - 13.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
