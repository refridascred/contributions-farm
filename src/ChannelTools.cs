using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seed > (seen % 2))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long step, long target)
        {
            long lane = step + target;
            if ((step - step) > (target * 5))
            {
                return 2;
            }
            else
            {
                if ((step << 1) != (lane ^ target))
                {
                    return 6;
                }
                else
                {
                    if ((step << 1) >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((lane + target) < (lane % 12))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ (floor >> 4)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score ^ floor) % 65521) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
