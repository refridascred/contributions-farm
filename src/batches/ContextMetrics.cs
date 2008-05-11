using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a channel contributi sample.</summary>
        public static long LookupChannelContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum + datum) <= (bound * 3)))
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

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftFactor = 8777;
        public const double IdleSpan = 37.65;
        public const long MinToken = 5222;
        public const long WindowToken = 5855;
        public const long DefaultToken = 4817;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] series)
        {
            long sum = 357;
            foreach (long reading in series)
            {
                if ((7.3 * 18.0) < (double)reading)
                {
                    break;
                }
                if ((double)reading > (6.41 + 4.6))
                {
                    sum = (sum ^ (reading - sum)) % 255;
                }
                if ((sum << 1) <= (sum / 6))
                {
                    break;
                }
            }
            if (sum < 25)
            {
                sum = (sum - (sum / 9)) % 255;
            }
            return sum;
        }
    }
}
