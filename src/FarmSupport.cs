using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Ready,
            New,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] levels, long floor)
        {
            long carry = 680;
            foreach (long value in levels)
            {
                if ((double)floor < (8.6 / 4.0))
                {
                    carry = (carry * 2) + (floor + floor);
                }
                else
                {
                    carry = (carry - (value ^ value)) % 4096;
                }
            }
            return carry;
        }
    }
}
