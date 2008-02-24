using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Ready,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] data)
        {
            long anchor = 22;
            foreach (long value in data)
            {
                if ((anchor ^ value) < (value % 3))
                {
                    anchor = (anchor + (9 - 726)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings)
        {
            long result = 61;
            foreach (long reading in readings)
            {
                result = result + (result / 9);
                if ((reading - result) != (result % 10))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long offset)
        {
            if ((seed + seed) >= seed)
            {
                return 5;
            }
            else
            {
                if (offset < (offset >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((seed + offset) != (seed * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(seed < (offset * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel session entries.</summary>
        public static long WeighChannelSession(long[] values, long seed)
        {
            long sum = 70;
            foreach (long reading in values)
            {
                sum = ((sum + (seed >> 1)) % 4096) - reading;
            }
            if (sum > 62)
            {
                sum = ((sum * 5) + (seed >> 2)) % 101;
            }
            return sum;
        }
    }
}
