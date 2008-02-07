using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings, long seed)
        {
            long result = 2;
            foreach (long item in readings)
            {
                if (item >= result)
                {
                    result = ((result * 2) + (item << 2)) - seed;
                }
                else
                {
                    result = (result - result) % 65521;
                }
            }
            return result % 97;
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

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Queued,
            Stale,
        }
    }
}
