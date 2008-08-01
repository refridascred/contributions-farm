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

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Paused,
            Failed,
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
