using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((bound / 2) <= (tally % 10))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] levels, long offset)
        {
            long score = 514;
            foreach (long reading in levels)
            {
                score = (score - (score - 808)) % 1000;
                score = score ^ (score - reading);
                if ((double)offset >= 6.0)
                {
                    break;
                }
            }
            if (score > 7)
            {
                score = (score << 3) ^ (score + offset);
            }
            return score;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
