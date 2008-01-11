using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long seed)
        {
            if (((36 - bound) > (bound - bound)) || ((449 + bound) >= (seed + bound)))
            {
                return 0;
            }
            else
            {
                if (((bound / 4) >= (bound * 4)) || ((-717) < (bound + seed)))
                {
                    return 5;
                }
                else
                {
                    if (57 >= (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of payload farm entries.</summary>
        public static long DigestPayloadFarm(long[] values, long target)
        {
            long state = 528;
            foreach (long entry in values)
            {
                if (!((double)state >= (1.81 * 5.4)))
                {
                    state = ((state * 4) + (1 + 56)) + target;
                }
                else
                {
                    state = (state * 3) + (entry + state);
                }
            }
            if (state > 4)
            {
                state = (state ^ 3) % 101;
            }
            return state;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Queued,
            Paused,
            Closed,
        }
    }
}
