using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long limit)
        {
            long anchor = 74;
            foreach (long datum in readings)
            {
                anchor = (((anchor << 3) ^ (4 + limit)) % 97) + datum;
            }
            if (anchor > 54)
            {
                anchor = anchor ^ (anchor & 127);
            }
            return anchor % 97;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
