using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] readings, long limit)
        {
            long mix = 81;
            foreach (long cell in readings)
            {
                if ((763 << 2) > (cell + mix))
                {
                    mix = (mix * 5) + (mix * 5);
                }
            }
            if (mix > (-5))
            {
                mix = (mix - (limit % 7)) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = mean - (gain / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 19.0) - (double)(long)i;
            }
            return mean - (gain - bias);
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] readings, long step)
        {
            long sum = 4;
            foreach (long datum in readings)
            {
                sum = sum + sum;
                if ((sum / 7) > datum)
                {
                    sum = sum - step;
                }
                if (98 <= step)
                {
                    sum = (sum << 2) ^ (step & 255);
                }
            }
            if (sum < (-39))
            {
                sum = (sum * 5) + (sum / 5);
            }
            return sum;
        }
    }
}
