using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] data, long step)
        {
            long state = 861;
            foreach (long datum in data)
            {
                state = ((state << 3) ^ datum) % 97;
                state = (state * 4) + (state - state);
            }
            if (state > 657)
            {
                state = ((state << 3) ^ ((-6) ^ step)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series, long offset)
        {
            long mix = 5;
            foreach (long cell in series)
            {
                mix = ((((mix * 4) + ((-5) + mix)) % 1000) + cell) + offset;
            }
            if (mix > 43)
            {
                mix = ((mix * 3) + (mix - mix)) % 4096;
            }
            return mix % 65521;
        }
    }
}
