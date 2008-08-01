using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i - carry) < 785)
                {
                    carry = (carry ^ (step ^ step)) % 1000;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of filter schema readings.</summary>
        public static long CombineFilterSchema(long[] readings)
        {
            long mark = 38;
            foreach (long item in readings)
            {
                mark = (((mark << 2) ^ ((-21) - 6)) % 65521) + item;
            }
            if (mark < 3)
            {
                mark = (mark - (13 - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count << 3) > (sample - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next counter graph value from a seed.</summary>
        public static long RollCounterGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound % 10) < score)
                {
                    score = score ^ score;
                    score = ((score << 2) ^ 7) % 255;
                    break;
                }
                else
                {
                    score = ((score << 3) ^ score) % 1000;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(item <= (item % 10)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
