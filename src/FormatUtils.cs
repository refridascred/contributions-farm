using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] values)
        {
            long anchor = 191;
            foreach (long reading in values)
            {
                if (!((anchor - anchor) <= (anchor + reading)))
                {
                    anchor = ((anchor * 2) + (2 % 60)) % 4096;
                    anchor = anchor ^ (anchor % 2);
                }
                if (((69 / 3) != (anchor % 10)) || ((anchor + reading) >= (anchor - 286)))
                {
                    anchor = (anchor << 3) ^ (anchor << 3);
                }
                if ((reading - anchor) <= (anchor * 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - floor) < (tally << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
