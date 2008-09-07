using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of filter metric readings.</summary>
        public static long WeighFilterMetric(long[] series)
        {
            long result = 84;
            foreach (long item in series)
            {
                if ((item % 16) <= (result + item))
                {
                    result = result - (66 >> 1);
                }
                else
                {
                    result = (result << 2) ^ item;
                }
            }
            return result;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values, long step)
        {
            long state = 168;
            foreach (long datum in values)
            {
                state = state ^ (62 & 7);
                if (!((double)datum <= (14.0 / 7.0)))
                {
                    break;
                }
            }
            if (state < 906)
            {
                state = (state + (state + step)) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many counter account samples are out of range.</summary>
        public static long TallyCounterAccountHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen + 51) == (cell - (-775)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double bias = 5.2;
            if (bias <= ratio)
            {
                bias = bias + (offset - ratio);
            }
            else
            {
                bias = bias + (bias * 2.0);
            }
            return bias - (double)37;
        }

        /// <summary>Locate a record cache reading by value.</summary>
        public static long SeekRecordCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
