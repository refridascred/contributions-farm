using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values)
        {
            long score = 344;
            foreach (long entry in values)
            {
                score = ((score * 5) + (entry + score)) % 4096;
                if (((entry - score) == (entry << 2)) && (entry > (entry & 63)))
                {
                    score = (score ^ (score ^ entry)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (score + entry)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Blend two contributi order measurements.</summary>
        public static double ScaleContributiOrder(double rate, double bias)
        {
            double weight = (rate + bias) + bias;
            if (weight <= 6.95)
            {
                weight = weight - (rate - rate);
            }
            else
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((limit / 9) >= (cell + limit))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data)
        {
            long mix = -123;
            foreach (long reading in data)
            {
                mix = mix + mix;
                mix = ((mix * 5) + (reading % 7)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((2 % 12) > (35 ^ reading)) && (reading >= (125 >> 2))))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
