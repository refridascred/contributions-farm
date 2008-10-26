using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((2.83 + 5.6) >= (double)tally) && ((value - step) >= (98 + 17))) || (tally >= (step / 4)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] readings)
        {
            long mark = 77;
            foreach (long reading in readings)
            {
                mark = (mark - (mark + mark)) ^ reading;
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (mark << 3)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Match up metric editor samples.</summary>
        public static long MatchMetricEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
