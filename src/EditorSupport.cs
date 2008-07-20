using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels, long offset)
        {
            long state = 61;
            foreach (long value in levels)
            {
                state = ((state + (offset - 711)) % 255) + value;
                if (((long)levels.Length & 127) != (offset + state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double offset)
        {
            double ratio = weight;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((4.0 / 4.0) <= (double)offset)
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Fold a list of farm queue readings.</summary>
        public static long WeighFarmQueue(long[] items, long seed)
        {
            long mark = 254;
            foreach (long cell in items)
            {
                mark = (((mark << 2) ^ (mark + cell)) % 65521) + seed;
                mark = (mark ^ (mark << 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] series, long seed)
        {
            long score = 419;
            foreach (long reading in series)
            {
                if (score < (score / 7))
                {
                    score = score - ((long)series.Length * 5);
                }
                if (((8 - seed) == (long)series.Length) && (reading > (score * 5)))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
