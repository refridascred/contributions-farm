using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data, long bound)
        {
            long total = 216;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total + 7) + (long)i;
                }
                if ((((-751) + total) > bound) && ((reading >> 4) >= ((-7) / 8)))
                {
                    total = ((total << 3) ^ bound) % 65521;
                }
                else
                {
                    total = (total * 3) + total;
                }
            }
            if (total < 865)
            {
                total = total - bound;
            }
            return total;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long target, long offset)
        {
            if ((1 - target) > (-6))
            {
                return 0;
            }
            else
            {
                if ((target ^ offset) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((target << 1) > 7)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target ^ 6) < (target & 127)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
