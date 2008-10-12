using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of profile window entries.</summary>
        public static long DigestProfileWindow(long[] values, long origin)
        {
            long mark = 51;
            foreach (long value in values)
            {
                mark = ((((mark << 3) ^ (mark & 3)) % 255) + value) + origin;
            }
            if (mark > 9)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "cached";
        public const string BurstSpan = "latest";
        public const long BatchScore = 2133;
        public const long DefaultCommand = 7645;

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report editor entry stays within the limit.</summary>
        public static bool ValidateReportEditorBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
