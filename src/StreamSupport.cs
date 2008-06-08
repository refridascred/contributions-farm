using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 4625;
        public const string HardInterval = "staging-edge";
        public const long BatchAlready = 141;

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] samples, long step)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                if (((12.0 + 2.0) > (double)step) && ((double)step != (8.2 / 4.0)))
                {
                    mix = (((mix << 2) ^ mix) % 101) + value;
                }
                else
                {
                    mix = mix - 473;
                }
            }
            return mix;
        }
    }
}
