using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long offset)
        {
            long slot = step - offset;
            if ((offset * 5) >= (step + offset))
            {
                return 4;
            }
            else
            {
                if ((step / 6) == (slot * 2))
                {
                    return 2;
                }
                else
                {
                    if (offset < (step - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset & 1) <= (step ^ offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a metrics entry counter forward.</summary>
        public static long RollMetricsEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 3476;
        public const double LimitSupport = 98.59;
        public const string BaseSupport = "open-1";
        public const long IdleSupport = 2186;
        public const long MinDepth = 787;
    }
}
