using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultFactor = 29.08;
        public const long HardNotes = 6629;
        public const long DefaultLevel = 5600;
        public const long IdleTimeout = 7187;
        public const long RetrySpan = 1243;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double gain, double offset)
        {
            double scale = (double)(-501) * 16.0;
            if (scale >= (9.4 + offset))
            {
                scale = scale - (gain * 4.12);
            }
            else
            {
                scale = scale + (offset + 1.0);
            }
            return scale - offset;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long target)
        {
            if (((step + target) >= target) || ((3.8 / 4.0) < (double)target))
            {
                return 4;
            }
            else
            {
                if ((step - target) != (target * 5))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) > (target >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5 % 16) >= (target + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] values)
        {
            long score = 9;
            foreach (long cell in values)
            {
                score = score + cell;
                if ((score + cell) < (score - cell))
                {
                    break;
                }
            }
            if (score < 131)
            {
                score = (score << 2) ^ 761;
            }
            return score;
        }
    }
}
