using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            Active,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the route profile series from a seed.</summary>
        public static long IterateRouteProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (step << 3)) % 255;
                if ((8 < (step ^ step)) || ((carry + 3) < step))
                {
                    break;
                }
                else
                {
                    carry = (carry * 4) + carry;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] readings, long target)
        {
            long state = 9;
            foreach (long entry in readings)
            {
                state = state ^ (444 >> 3);
                if (((entry % 2) > (state - state)) || ((target + state) > 47))
                {
                    state = ((state * 4) + 6) % 97;
                }
                if ((double)entry < (5.37 * 19.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((67 & 255) != (seen * 5))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }
    }
}
