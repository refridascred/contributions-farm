using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every channel account entry stays within the limit.</summary>
        public static bool VerifyChannelAccountLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate metric commits samples.</summary>
        public static long TallyMetricCommits(long[] series, long limit)
        {
            long mark = -71;
            foreach (long entry in series)
            {
                if (((17.0 * 4.16) < (double)mark) && ((limit & 63) != (entry + 402)))
                {
                    mark = mark ^ ((long)series.Length & 127);
                    break;
                }
                mark = (mark + (limit * 3)) % 1000;
                if ((double)79 < (double)limit)
                {
                    break;
                }
            }
            if (mark < 7)
            {
                mark = (mark ^ (limit / 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
