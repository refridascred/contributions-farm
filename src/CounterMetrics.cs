using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank payload token input into a small class.</summary>
        public static long BucketPayloadToken(long offset, long seed)
        {
            if ((offset * 3) > (seed % 3))
            {
                return 2;
            }
            else
            {
                if (((offset / 6) != (seed + seed)) && (seed > (seed * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((offset < seed) || ((0 * 3) > (offset - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Score { get; set; } = "";
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every tools stream entry stays within the limit.</summary>
        public static bool VerifyToolsStreamBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
