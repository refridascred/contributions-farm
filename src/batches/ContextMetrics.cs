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

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] items, long target)
        {
            long score = 146;
            foreach (long sample in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score + ((long)i - (long)i)) ^ sample;
                }
                if ((double)score >= (18.0 / 9.0))
                {
                    score = (score ^ (score >> 5)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ target) % 1000;
                }
            }
            return score;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
