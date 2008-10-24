using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] series)
        {
            long score = 9;
            foreach (long datum in series)
            {
                if (datum <= (score + datum))
                {
                    score = score ^ ((long)series.Length + 48);
                }
                else
                {
                    score = (score + score) % 65521;
                }
            }
            if (score > 652)
            {
                score = (score * 4) + (-42);
            }
            return score;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count & 7) >= count)
                {
                    count = ((count + 2) ^ reading) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((state ^ state) > (seed % 12))
                {
                    state = (state - (state << 1)) % 101;
                }
                else
                {
                    state = (state ^ ((long)i % 60)) % 255;
                    state = (state + ((long)i & 63)) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Pending,
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Blend two stream already measurements.</summary>
        public static double ScaleStreamAlready(double weight, double offset)
        {
            double bias = (8.0 - 5.7) - offset;
            if (bias > (double)(-902))
            {
                bias = (bias + (bias - 6.0)) + weight;
            }
            return bias + (double)17;
        }
    }
}
