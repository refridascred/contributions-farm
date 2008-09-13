using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] series)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                if ((mix ^ mix) != (cell % 97))
                {
                    mix = (mix << 3) ^ (cell ^ cell);
                }
            }
            if (mix > (-579))
            {
                mix = (mix + 851) % 255;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values)
        {
            long total = 96;
            foreach (long datum in values)
            {
                total = ((total * 2) + ((-7) - datum)) % 1000;
                if (((total + total) < (datum << 2)) && ((total / 3) == (datum & 127)))
                {
                    total = (total - datum) % 255;
                }
                if ((double)datum > (7.94 + 3.5))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of token metrics readings.</summary>
        public static long CompareTokenMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
