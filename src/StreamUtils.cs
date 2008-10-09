using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up order githubfarm samples.</summary>
        public static long OverlapOrderGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Dropped,
            Paused,
            New,
            Ready,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long step, long floor)
        {
            if ((double)floor >= (2.0 * 7.2))
            {
                return 8;
            }
            else
            {
                if ((3.2 * 19.0) != (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (floor < (step - 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step <= (floor + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a buffer contributi counter forward.</summary>
        public static long StepBufferContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((origin - (-3)) >= (long)i)
                {
                    carry = (carry << 2) ^ origin;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 9010;
        public const long LimitTimeout = 2802;
        public const double MaxOrder = 71.46;
        public const long MaxScore = 4717;
    }
}
