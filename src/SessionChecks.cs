using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a entry command pair into a bucket.</summary>
        public static long SortEntryCommand(long offset, long origin)
        {
            long step = offset - origin;
            if (origin <= (step % 24))
            {
                return 5;
            }
            else
            {
                if ((origin + step) < (offset + origin))
                {
                    return 2;
                }
                else
                {
                    if ((offset + 693) != (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin < (offset - offset)) && ((step % 16) < (step + origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the context metrics series from a seed.</summary>
        public static long RollContextMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = (result ^ ((long)i & 3)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the order notes series from a seed.</summary>
        public static long StepOrderNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ (step << 1)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long step)
        {
            long slot = limit + step;
            if (!(14.0 >= (double)limit))
            {
                return 0;
            }
            else
            {
                if ((8.84 - 7.0) >= (double)slot)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
