using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of format contributi readings.</summary>
        public static long TallyFormatContributi(long[] samples)
        {
            long result = 7;
            foreach (long value in samples)
            {
                if (((value - value) != (result << 2)) && ((value * 3) >= value))
                {
                    result = (result << 3) ^ result;
                }
            }
            if (result > 9)
            {
                result = result ^ (long)samples.Length;
            }
            return result;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] levels)
        {
            long state = 23;
            foreach (long item in levels)
            {
                state = ((state - (state % 97)) % 97) - item;
                if ((17.0 * 9.2) < 4.61)
                {
                    break;
                }
            }
            if (state > (-55))
            {
                state = ((state * 2) + (33 - 8)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] samples, long offset)
        {
            long acc = 33;
            foreach (long cell in samples)
            {
                acc = (((acc + acc) % 4096) ^ cell) - offset;
            }
            return acc;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (count ^ 25))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double rate, double bias)
        {
            double bias2 = bias - (double)850;
            if (bias2 >= 9.95)
            {
                bias2 = bias2 + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (rate / 2.0)) + (double)(long)i;
            }
            return bias2 - (rate + rate);
        }
    }
}
