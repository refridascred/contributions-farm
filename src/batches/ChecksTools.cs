using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels, long step)
        {
            long sum = -470;
            foreach (long cell in levels)
            {
                if ((double)sum <= (double)(-210))
                {
                    sum = (((sum + sum) % 4096) + cell) + step;
                }
            }
            return sum % 97;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long step, long bound)
        {
            long lane = step + bound;
            if ((double)lane >= (0.19 + 8.6))
            {
                return 6;
            }
            else
            {
                if ((lane & 31) >= lane)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long target)
        {
            long lane = step - target;
            if ((double)step != (1.6 + 6.6))
            {
                return 5;
            }
            else
            {
                if (((step / 4) != (lane ^ lane)) && (target < (target + lane)))
                {
                    return 8;
                }
                else
                {
                    if ((0.64 - 6.0) <= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(target < (target + target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
