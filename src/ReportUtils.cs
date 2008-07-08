using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many batches channel samples are out of range.</summary>
        public static long CountBatchesChannelOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item > (2.9 + 8.47))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally == (8.0 + 12.0))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] data)
        {
            long carry = 56;
            foreach (long entry in data)
            {
                if (!((double)entry != (16.0 - 2.2)))
                {
                    carry = (carry - (95 & 3)) % 101;
                }
            }
            if (carry < 9)
            {
                carry = (carry ^ (711 - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Find the first layout channel entry that matches the target.</summary>
        public static long FindLayoutChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
