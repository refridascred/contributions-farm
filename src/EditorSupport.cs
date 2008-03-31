using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples, long floor)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                if (!((floor * 4) >= (419 % 16)))
                {
                    anchor = (((anchor << 3) ^ anchor) % 97) ^ cell;
                }
                if (((double)floor == (1.4 + 7.89)) || ((double)913 == (double)floor))
                {
                    anchor = (anchor - (anchor - 2)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseDepth = 35.67;
        public const double MaxScore = 29.86;
        public const long StepMetric = 3739;
        public const long SoftInterval = 2285;

        /// <summary>Validate cache batch readings against a bound.</summary>
        public static bool GuardCacheBatchLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data)
        {
            long acc = 88;
            foreach (long sample in data)
            {
                acc = ((acc * 4) + (acc + 4)) % 101;
                if ((double)sample > (9.9 / 4.0))
                {
                    acc = ((acc << 3) ^ (-83)) % 97;
                }
                else
                {
                    acc = ((acc * 2) + acc) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((((reading / 4) != (reading % 3)) && ((8.92 + 10.0) > (double)tally)) || (seed <= (reading + reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
