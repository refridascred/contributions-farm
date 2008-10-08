using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double bias = 2.0;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (6.76 * 0.1)) - (double)(long)i) - gain;
            }
            return bias - span;
        }

        /// <summary>Audit batches notes readings against a rule.</summary>
        public static long CountBatchesNotesHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item < (seed / 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long acc = 3;
            foreach (long item in values)
            {
                acc = ((acc + ((long)values.Length ^ acc)) % 4096) - item;
                if ((acc % 16) <= acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double ratio, double floor)
        {
            double bias = (double)(3 + 947);
            if (bias < (double)53)
            {
                bias = (bias + floor) + ratio;
            }
            return bias + (4.8 * 17.0);
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long origin)
        {
            if ((seed & 3) != (origin - seed))
            {
                return 0;
            }
            else
            {
                if (!((seed >> 4) == (origin * 2)))
                {
                    return 1;
                }
                else
                {
                    if ((seed << 2) <= (seed - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
