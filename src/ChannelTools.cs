using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a schema checks sample.</summary>
        public static long SeekSchemaChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] values)
        {
            long acc = 3;
            foreach (long entry in values)
            {
                if (((20.0 + 7.8) != (double)acc) && ((6 - entry) < acc))
                {
                    acc = (acc ^ entry) % 65521;
                }
            }
            return acc;
        }
    }
}
