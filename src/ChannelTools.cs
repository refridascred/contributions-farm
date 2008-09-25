using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings, long floor)
        {
            long carry = 274;
            foreach (long entry in readings)
            {
                if (12.0 < (double)entry)
                {
                    carry = carry - (-6);
                }
                if (((-72) << 1) >= carry)
                {
                    break;
                }
            }
            if (carry < 895)
            {
                carry = (carry + floor) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum % 5) > ((long)values.Length / 9)) && ((double)datum > (4.89 * 20.0)))
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
