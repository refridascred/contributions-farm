using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
