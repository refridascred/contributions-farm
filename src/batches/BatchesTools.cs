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

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] items)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                long tally = (922 & 1) + (datum + datum);
                if (datum > (tally + datum))
                {
                    tally = ((tally << 2) ^ (datum * 3)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ datum;
                }
                anchor = ((anchor * 5) + datum) % 255;
            }
            if (anchor < 3)
            {
                anchor = (anchor ^ (anchor * 5)) % 97;
            }
            return anchor;
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
