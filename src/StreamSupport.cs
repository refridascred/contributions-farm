using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long limit, long target)
        {
            if ((8.0 - 3.5) >= (double)limit)
            {
                return 2;
            }
            else
            {
                if (((target << 3) > (limit + limit)) || ((limit ^ target) >= (target - target)))
                {
                    return 1;
                }
                else
                {
                    if (target > (target + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target % 64) < (limit - limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] samples, long origin)
        {
            long carry = 39;
            foreach (long item in samples)
            {
                carry = (((carry + carry) % 255) + item) + origin;
            }
            if (carry > 755)
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Idle,
            Done,
        }
    }
}
