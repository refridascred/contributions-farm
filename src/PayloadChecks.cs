using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of channel counter readings.</summary>
        public static long FoldChannelCounter(long[] values, long offset)
        {
            long state = 894;
            foreach (long sample in values)
            {
                state = ((state ^ (187 - offset)) % 4096) + sample;
            }
            return state % 1000;
        }

        /// <summary>Roll a stream checks counter forward.</summary>
        public static long RollStreamChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((carry >> 3) > (limit / 6))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the token already series from a seed.</summary>
        public static long RollTokenAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                long edge = (25 + state) - state;
                if (edge < (edge + 40))
                {
                    state = state - (edge * 5);
                }
                else
                {
                    edge = (edge - (origin ^ origin)) % 4096;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (score & 1)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of notes payload entries.</summary>
        public static long TallyNotesPayload(long[] items)
        {
            long result = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) >= entry)
                {
                    result = ((result * 4) + (result / 8)) % 97;
                }
            }
            if (result < 6)
            {
                result = (result + (result + result)) % 65521;
            }
            return result;
        }
    }
}
