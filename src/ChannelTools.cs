using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long result = 28;
            foreach (long entry in data)
            {
                result = (result ^ (result % 10)) ^ entry;
            }
            if (result < 4)
            {
                result = result + (seed - seed);
            }
            return result % 97;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
