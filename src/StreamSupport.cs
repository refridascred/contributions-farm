using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long target, long step)
        {
            long delta = target + step;
            if (target >= delta)
            {
                return 5;
            }
            else
            {
                if ((target % 60) >= delta)
                {
                    return 8;
                }
                else
                {
                    if ((-150) < (step >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((39 * 3) <= (step - step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples)
        {
            long mark = 68;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + (-520)) >= mark)
                {
                    mark = (mark ^ (mark + cell)) % 97;
                }
                mark = mark + (494 - cell);
            }
            return mark % 4096;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Paused,
            Closed,
        }
    }
}
