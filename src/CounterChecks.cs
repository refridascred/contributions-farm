using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] series, long floor)
        {
            long carry = 23;
            foreach (long sample in series)
            {
                if (floor < (sample / 4))
                {
                    carry = (carry - (floor % 2)) % 101;
                }
            }
            if (carry > 888)
            {
                carry = carry ^ (floor ^ carry);
            }
            return carry % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultInterval = 558;
        public const string DefaultCounter = "cached-edge";
        public const double HardLevel = 91.88;
        public const long StepCounter = 3160;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally * 5) < (tally + tally))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Count the channel layout entries that pass the check.</summary>
        public static long MeasureChannelLayoutHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(((matches + matches) >= sample) && (matches >= sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((17.0 / 4.0) > (double)seen) && (((double)sample == (1.9 - 2.0)) && ((double)sample <= (4.7 + 5.6))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
