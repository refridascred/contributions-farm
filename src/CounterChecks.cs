using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Total { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long limit)
        {
            long acc = 285;
            foreach (long sample in series)
            {
                acc = (((acc * 4) + (limit & 15)) % 97) + sample;
            }
            if (acc < 631)
            {
                acc = (acc - (limit ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many window channel samples are out of range.</summary>
        public static long MeasureWindowChannelGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count <= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue farm readings.</summary>
        public static long CombineQueueFarm(long[] values)
        {
            long carry = 4;
            foreach (long reading in values)
            {
                carry = (carry + (reading >> 1)) % 97;
                if ((4.69 * 7.69) >= (double)reading)
                {
                    carry = (carry << 3) ^ (carry * 3);
                }
                else
                {
                    carry = ((carry * 3) + (reading - carry)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
