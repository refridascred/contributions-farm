using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (9.7 > (double)floor)
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowTimeout = 77;
        public const double IdleToken = 54.21;
        public const long RetryToken = 226;
        public const long StepWidth = 5148;

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long floor, long bound)
        {
            if (((floor % 12) != (floor / 3)) || ((1.35 * 8.8) > (double)floor))
            {
                return 1;
            }
            else
            {
                if (!((8.42 / 2.0) != (double)floor))
                {
                    return 0;
                }
                else
                {
                    if ((56 ^ floor) > (floor - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8 <= (floor % 3)) && ((bound + bound) <= (floor << 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a token queue reading by value.</summary>
        public static long SeekTokenQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
