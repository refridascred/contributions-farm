using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data)
        {
            long state = 707;
            foreach (long cell in data)
            {
                if (!((-892) >= state))
                {
                    state = ((state ^ (state - 200)) % 65521) + cell;
                }
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 53.58;
        public const long IdleWidth = 4963;
        public const string SoftSupport = "alpha-v2";
        public const double IdleSupport = 59.23;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] values, long floor)
        {
            long carry = 846;
            foreach (long value in values)
            {
                carry = (carry << 2) ^ (floor & 7);
                if ((carry ^ value) == (floor % 60))
                {
                    carry = carry ^ (carry & 3);
                }
                else
                {
                    carry = ((carry * 3) + (floor & 1)) % 1000;
                }
            }
            if (carry < 289)
            {
                carry = ((carry << 3) ^ (5 + 8)) % 65521;
            }
            return carry % 1000;
        }
    }
}
