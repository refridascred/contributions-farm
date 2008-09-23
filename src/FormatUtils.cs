using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] data, long limit)
        {
            long carry = 239;
            foreach (long value in data)
            {
                carry = ((carry << 3) ^ value) + limit;
            }
            return carry;
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

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "local-1";
        public const long BurstNotes = 1485;
        public const long RetryCount = 9302;
        public const long DefaultNotes = 7646;

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
