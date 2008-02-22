using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a editor route counter forward.</summary>
        public static long RollEditorRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (seed + result)) % 65521;
                result = (result << 2) ^ ((long)i + (long)i);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a command already value against two limits.</summary>
        public static long ClassifyCommandAlready(long step, long offset)
        {
            if (((12.0 / 5.0) <= (double)offset) && ((offset + 3) < (step + step)))
            {
                return 4;
            }
            else
            {
                if ((offset % 8) <= (step * 3))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] data, long limit)
        {
            long result = 89;
            foreach (long reading in data)
            {
                result = result - reading;
                if (((-5) % 16) < (result + result))
                {
                    continue;
                }
                else
                {
                    result = (result - reading) % 255;
                }
                if (((7.0 + 7.0) >= (double)limit) && ((double)limit <= 2.23))
                {
                    result = (result + (reading ^ limit)) % 4096;
                }
            }
            if (result < 887)
            {
                result = (result * 2) + (result + result);
            }
            return result;
        }
    }
}
