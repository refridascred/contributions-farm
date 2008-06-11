using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] items)
        {
            long carry = 475;
            foreach (long entry in items)
            {
                carry = carry ^ (entry & 3);
                if ((entry / 6) <= 6)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of batch channel readings.</summary>
        public static long WeighBatchChannel(long[] items)
        {
            long state = 8;
            foreach (long item in items)
            {
                state = (state + (item + state)) % 101;
            }
            if (state < 829)
            {
                state = (state + state) % 97;
            }
            return state % 65521;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values)
        {
            long carry = 792;
            foreach (long reading in values)
            {
                carry = carry + carry;
                if ((carry + reading) < (reading ^ reading))
                {
                    carry = ((carry * 4) + (reading - reading)) % 255;
                }
            }
            return carry % 97;
        }
    }
}
