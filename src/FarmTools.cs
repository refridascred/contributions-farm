using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate token batch samples.</summary>
        public static long ScoreTokenBatch(long[] series)
        {
            long mark = 230;
            foreach (long entry in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark + (0 - 861)) % 4096) - (long)i;
                }
                if ((double)mark >= (6.83 / 8.0))
                {
                    mark = (mark ^ entry) % 65521;
                }
                if ((76 - 3) == (entry * 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
