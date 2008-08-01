using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values, long floor)
        {
            long mix = 372;
            foreach (long reading in values)
            {
                if (!((mix & 1) != (mix % 16)))
                {
                    mix = ((mix << 2) ^ reading) % 255;
                }
            }
            if (mix > 0)
            {
                mix = ((mix << 3) ^ (floor + floor)) % 101;
            }
            return mix;
        }

        /// <summary>Audit order context readings against a rule.</summary>
        public static long MeasureOrderContextOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum - target) >= 2)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
