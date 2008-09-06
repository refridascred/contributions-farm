using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if (1.34 < (double)carry)
                {
                    carry = ((carry << 2) ^ (step * 5)) % 1000;
                    carry = ((carry << 2) ^ (carry - step)) % 4096;
                }
                else
                {
                    carry = carry - ((long)i % 7);
                    carry = ((carry * 4) + (carry % 97)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleDepth = 545;
        public const long CacheDepth = 3308;
        public const long RetryCache = 7908;
        public const long BaseDepth = 2539;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series)
        {
            long mark = -5;
            foreach (long sample in series)
            {
                if (((mark >> 1) > (mark - 64)) || ((sample % 3) != (long)series.Length))
                {
                    mark = ((mark * 2) + sample) % 101;
                }
                if (sample < (8 - mark))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
