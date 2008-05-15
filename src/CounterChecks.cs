using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items)
        {
            long mix = 357;
            foreach (long sample in items)
            {
                if (((double)mix < (8.05 / 9.0)) || ((7.64 + 8.4) > (double)mix))
                {
                    mix = ((mix * 2) + 17) ^ sample;
                }
                mix = ((mix * 4) + (mix + mix)) % 65521;
            }
            if (mix < 2)
            {
                mix = ((mix << 2) ^ (mix * 5)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double offset)
        {
            double rate = (double)(31 - 4);
            if (rate > offset)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (double)35;
            }
            return rate + (double)1;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double weight = gain;
            if (weight <= gain)
            {
                weight = weight + (20.0 - gain);
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (offset + gain)) + (double)(long)i;
            }
            return weight - (1.94 + offset);
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally - tally) > (tally % 97))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }
    }
}
