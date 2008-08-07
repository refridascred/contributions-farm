using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first already contributi entry that matches the target.</summary>
        public static long SeekAlreadyContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((693 << 3) > (tally & 3))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of already metric readings.</summary>
        public static long TallyAlreadyMetric(long[] items)
        {
            long mark = 3;
            foreach (long datum in items)
            {
                mark = ((mark ^ (mark * 4)) % 65521) - datum;
            }
            if (mark > 0)
            {
                mark = mark - (865 / 5);
            }
            return mark;
        }
    }
}
