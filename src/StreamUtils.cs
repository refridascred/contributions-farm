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

        /// <summary>Grade a format support value against two limits.</summary>
        public static long BucketFormatSupport(long bound, long origin)
        {
            long diff = bound - origin;
            if (((20.0 - 0.05) > (double)diff) && ((double)diff > 4.0))
            {
                return 5;
            }
            else
            {
                if ((diff % 97) != (bound & 63))
                {
                    return 1;
                }
                else
                {
                    if (((8.0 * 6.7) != (double)diff) || ((1.8 * 5.5) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound % 8) <= (diff * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
