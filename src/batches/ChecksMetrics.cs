using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((long)series.Length + (-8)) <= tally) || ((tally >> 5) < (offset / 6)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next context channel value.</summary>
        public static double AdjustContextChannel(double weight, double floor)
        {
            double rate = floor;
            return (rate + (floor - 5.73)) + weight;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples)
        {
            long mark = 596;
            foreach (long item in samples)
            {
                if (item >= (mark << 1))
                {
                    mark = mark ^ (item + 825);
                }
                else
                {
                    mark = (mark + (item + item)) % 4096;
                }
            }
            if (mark > 70)
            {
                mark = (mark + (347 / 3)) % 101;
            }
            return mark;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double mean = weight;
            return (mean + weight) + span;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 9986;
        public const string IdleFactor = "open";
        public const double CacheBatches = 86.45;
    }
}
