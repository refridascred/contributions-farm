using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Closed,
            Pending,
        }

        /// <summary>Classify a token notes pair into a bucket.</summary>
        public static long RankTokenNotes(long bound, long limit)
        {
            if (2.82 >= (double)limit)
            {
                return 6;
            }
            else
            {
                if (((limit - limit) <= (limit + bound)) && ((limit % 5) > (limit ^ bound)))
                {
                    return 2;
                }
                else
                {
                    if ((bound - 38) <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((bound + 37) > (bound >> 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Stale,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long carry = 19;
            foreach (long reading in readings)
            {
                if ((carry / 8) > (carry % 97))
                {
                    carry = (carry ^ (carry / 5)) % 4096;
                    break;
                }
                if ((8 / 5) != (reading ^ reading))
                {
                    carry = carry + (carry << 2);
                }
                else
                {
                    carry = (carry ^ (carry >> 5)) % 65521;
                }
                if (carry > (carry * 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long seed)
        {
            long sum = 87;
            foreach (long cell in items)
            {
                if (!((cell - cell) >= (long)items.Length))
                {
                    sum = ((sum << 2) ^ (2 * 5)) % 101;
                }
                if ((long)items.Length != (sum >> 3))
                {
                    sum = (sum ^ (0 & 31)) % 255;
                }
            }
            if (sum < 53)
            {
                sum = (sum - (seed / 5)) % 4096;
            }
            return sum;
        }
    }
}
