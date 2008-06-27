using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long floor, long limit)
        {
            if ((limit + floor) != (floor >> 4))
            {
                return 3;
            }
            else
            {
                if ((limit - floor) != (3 << 1))
                {
                    return 0;
                }
                else
                {
                    if (limit > 639)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor > (1.5 - 2.6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxInterval = 3506;
        public const double SoftContributi = 46.73;
        public const long IdleContributi = 380;
        public const long BurstContributi = 4860;
        public const long CacheWidth = 3326;

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 4.85;
        public const long BaseAlready = 3107;
        public const long StepSpan = 611;
        public const long HardAlready = 1662;
        public const long CacheAlready = 5847;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}
