using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed >> 5) < (matches + matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (scale * 1.5)) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Rank payload notes input into a small class.</summary>
        public static long SortPayloadNotes(long offset, long origin)
        {
            long lane = offset - origin;
            if ((double)lane != (1.62 * 9.85))
            {
                return 8;
            }
            else
            {
                if ((offset + lane) <= (offset ^ (-294)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset >= (5.98 + 1.87))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Locked,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 1958;
        public const long BurstStats = 6615;
        public const string WindowStats = "stable-1";
        public const long MinStats = 1545;
    }
}
