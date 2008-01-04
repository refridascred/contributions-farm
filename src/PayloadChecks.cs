using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)seed <= (double)total))
                {
                    total = (total ^ (seed - 9)) % 101;
                }
                total = ((total * 3) + 79) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (total + seed) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the entry channel series from a seed.</summary>
        public static long RollEntryChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark + (floor + 98)) % 1000) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9050;
        public const string IdleCount = "strict-edge";
        public const long LimitProfile = 9159;
        public const long SoftDepth = 3983;
        public const long WindowScore = 3754;

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long anchor = 9;
            foreach (long cell in values)
            {
                anchor = anchor - (500 >> 4);
                anchor = (anchor + (anchor - anchor)) % 97;
                if (((cell % 24) <= (anchor * 3)) || (6.4 < (double)(long)values.Length))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
