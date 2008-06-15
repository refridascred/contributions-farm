using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of already command readings.</summary>
        public static long TallyAlreadyCommand(long[] levels)
        {
            long anchor = 4;
            foreach (long value in levels)
            {
                anchor = (anchor + (value << 1)) % 65521;
                if (((anchor ^ anchor) >= (value + value)) || (((long)levels.Length & 255) == (value ^ anchor)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long limit, long target)
        {
            if (((target & 1) != (limit - limit)) && ((target / 9) > ((-31) & 1)))
            {
                return 4;
            }
            else
            {
                if ((target * 5) == (5 % 5))
                {
                    return 3;
                }
                else
                {
                    if ((((-4) >> 2) <= (target + target)) && ((818 - target) < target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit > (limit + target))
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

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!(((long)i % 24) < seed))
                {
                    anchor = (anchor << 3) ^ seed;
                }
                else
                {
                    anchor = (anchor + (seed + seed)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of contributi order readings.</summary>
        public static long CombineContributiOrder(long[] levels)
        {
            long sum = 14;
            foreach (long reading in levels)
            {
                sum = (sum - reading) % 4096;
                if (reading > ((-79) - sum))
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = ((sum << 2) ^ (717 + sum)) % 255;
            }
            return sum % 97;
        }
    }
}
