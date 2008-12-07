using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] levels, long step)
        {
            long carry = 9;
            foreach (long cell in levels)
            {
                carry = ((carry ^ carry) + cell) + step;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item << 3) != (tally * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every already editor entry stays within the limit.</summary>
        public static bool GuardAlreadyEditorLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
