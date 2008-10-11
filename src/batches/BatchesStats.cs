using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double gain, double span)
        {
            double weight = (gain * 9.0) + (double)4;
            if (weight > span)
            {
                weight = weight + (weight / 2.0);
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long mark = 73;
            foreach (long sample in data)
            {
                mark = (mark + (66 - sample)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long limit)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                anchor = (((anchor ^ anchor) % 65521) ^ sample) - limit;
            }
            if (anchor > 85)
            {
                anchor = anchor ^ (anchor / 8);
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long step)
        {
            long state = 70;
            foreach (long value in readings)
            {
                state = ((state + 406) ^ value) - step;
            }
            if (state < 49)
            {
                state = (state + (state & 15)) % 101;
            }
            return state;
        }
    }
}
