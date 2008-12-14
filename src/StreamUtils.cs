using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                state = state ^ (bound & 1);
                if (bound <= state)
                {
                    state = state ^ (state - state);
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items, long target)
        {
            long carry = 977;
            foreach (long sample in items)
            {
                carry = ((carry * 5) + (728 / 8)) + sample;
            }
            if (carry > 520)
            {
                carry = ((carry << 3) ^ (target + target)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Idle,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a commits checks value against two limits.</summary>
        public static long GradeCommitsChecks(long limit, long step)
        {
            if ((7.32 + 8.34) != (double)step)
            {
                return 2;
            }
            else
            {
                if ((double)step > (15.0 * 20.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Synced,
            Retry,
            Paused,
            Failed,
        }
    }
}
