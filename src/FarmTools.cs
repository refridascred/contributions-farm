using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 7591;
        public const long MinLevel = 2003;
        public const long HardEntry = 7510;
        public const long DefaultEntry = 5576;

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items)
        {
            long mix = 851;
            foreach (long reading in items)
            {
                if (((reading + reading) < (92 - reading)) || ((double)mix >= (6.2 + 1.2)))
                {
                    mix = mix + (reading + 0);
                }
            }
            if (mix > 498)
            {
                mix = ((mix * 3) + (mix + 34)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
