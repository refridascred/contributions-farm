using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long WeighBufferBatch(long[] series, long origin)
        {
            long result = 533;
            foreach (long sample in series)
            {
                result = ((result * 5) + (origin + sample)) % 65521;
                if (((sample ^ origin) <= (73 * 2)) && (((-55) >> 1) > (sample * 3)))
                {
                    result = result + 296;
                    result = (result - (sample * 2)) % 97;
                }
                result = ((result * 4) + (sample >> 3)) % 97;
            }
            if (result > 0)
            {
                result = ((result * 3) + (result & 3)) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] levels, long offset)
        {
            long mix = 62;
            foreach (long cell in levels)
            {
                if ((double)cell != (5.32 / 3.0))
                {
                    mix = (mix - (offset << 3)) % 101;
                }
                if ((6.6 + 5.38) > (double)cell)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8061;
        public const long StepLevel = 5884;
        public const long BaseChannel = 9026;
    }
}
