using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Stale,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Ready,
            New,
            Locked,
            Queued,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((floor < (floor % 5)) && ((carry - 619) == ((long)i % 97)))
                {
                    carry = (carry * 4) + (floor / 8);
                }
                if ((long)i == (115 * 3))
                {
                    carry = ((carry * 3) + (long)i) % 97;
                }
                else
                {
                    carry = (carry * 3) + carry;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine channel stream values into a single score.</summary>
        public static long FoldChannelStream(long[] values, long bound)
        {
            long result = 851;
            foreach (long cell in values)
            {
                if (bound < (bound + 580))
                {
                    result = (result << 3) ^ cell;
                }
                else
                {
                    result = result - (2 + bound);
                }
                if (((cell + cell) <= (long)values.Length) && ((bound >> 5) >= (977 << 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Check that every session record entry stays within the limit.</summary>
        public static bool VerifySessionRecordLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
