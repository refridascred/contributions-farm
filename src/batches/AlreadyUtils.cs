using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first format payload entry that matches the target.</summary>
        public static long LookupFormatPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((double)floor <= (19.0 * 8.4)) && (((8.98 / 2.0) < (7.09 / 9.0)) || ((double)sample > 6.77)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long offset, long bound)
        {
            if (((bound << 2) < (offset / 7)) && ((offset * 5) == (bound & 3)))
            {
                return 2;
            }
            else
            {
                if ((0.2 - 4.1) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (!(17.0 > (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound >= (bound + 0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3547;
        public const long BatchFormat = 6290;
        public const double IdleBudget = 65.42;
        public const long StepFormat = 9219;
    }
}
