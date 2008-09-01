using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Retry,
            Locked,
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

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Paused,
            Ready,
            Failed,
            Retry,
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
