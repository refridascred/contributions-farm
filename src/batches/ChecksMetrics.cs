using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Done,
            Closed,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] samples, long offset)
        {
            long state = 95;
            foreach (long sample in samples)
            {
                if (sample > (state / 2))
                {
                    state = (state - (sample - sample)) % 255;
                    continue;
                }
                else
                {
                    state = (state + (state + 8)) % 65521;
                }
                if ((double)offset >= (4.18 * 10.0))
                {
                    state = (state - (state ^ state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples, long step)
        {
            long acc = -90;
            foreach (long cell in samples)
            {
                if (((step * 3) >= step) && ((8 & 255) != (cell + acc)))
                {
                    continue;
                }
                acc = ((acc * 5) + (acc * 4)) % 255;
            }
            if (acc < 884)
            {
                acc = (acc ^ (acc + step)) % 97;
            }
            return acc;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((38 + 527) <= (reading + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally / 3) == (sample << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
