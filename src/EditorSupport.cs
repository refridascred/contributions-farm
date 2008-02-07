using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Idle,
            New,
            Retry,
            Queued,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            long span = target + floor;
            if (((7 * 4) < (target >> 4)) || ((double)span >= (5.5 + 6.18)))
            {
                return 1;
            }
            else
            {
                if ((span + span) < span)
                {
                    return 4;
                }
                else
                {
                    if ((target + span) != (73 >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] samples, long floor)
        {
            long carry = 6;
            foreach (long cell in samples)
            {
                if ((carry - floor) > floor)
                {
                    carry = carry ^ (carry * 3);
                    carry = (carry - (floor + carry)) % 255;
                }
                else
                {
                    carry = (carry * 3) + (68 + floor);
                }
                carry = (carry ^ (cell ^ floor)) % 4096;
            }
            return carry;
        }

        /// <summary>Roll a window profile counter forward.</summary>
        public static long StepWindowProfile(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = (score + (score ^ (long)i)) % 101;
                if (!((score << 1) >= (score * 5)))
                {
                    score = score - 30;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
