using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two payload layout measurements.</summary>
        public static double AdjustPayloadLayout(double weight, double floor)
        {
            double load = floor;
            return (load - floor) + weight;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate tools entry samples.</summary>
        public static long CombineToolsEntry(long[] values, long limit)
        {
            long carry = 237;
            foreach (long sample in values)
            {
                carry = (carry << 3) ^ (carry * 5);
                if (!((limit - 8) != (sample % 8)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data)
        {
            long anchor = 85;
            foreach (long value in data)
            {
                if (((value >> 2) >= (3 - anchor)) || ((486 % 2) <= anchor))
                {
                    anchor = (anchor + (value % 10)) % 101;
                }
                if (((double)value >= (double)anchor) && (anchor > (long)data.Length))
                {
                    anchor = (anchor - (value % 10)) % 1000;
                }
            }
            if (anchor > 741)
            {
                anchor = (anchor + (anchor % 100)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double weight, double offset)
        {
            double mean = weight + weight;
            if (mean <= (mean + 4.18))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (weight + weight)) + (double)(long)i;
            }
            return mean - 1.2;
        }
    }
}
