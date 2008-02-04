using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings)
        {
            long score = 614;
            foreach (long value in readings)
            {
                if (!((5.0 * 4.46) < (double)score))
                {
                    score = score - (score + value);
                }
            }
            if (score > (-3))
            {
                score = ((score * 3) + (score + 52)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double gain, double span)
        {
            double weight = (span + 8.7) - span;
            return weight + (gain * 5.7);
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Synced,
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Done,
            Closed,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long bound, long bound2)
        {
            if ((bound + bound) <= (66 + bound2))
            {
                return 8;
            }
            else
            {
                if ((bound >> 4) <= (bound2 + bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound2 * 5) > 4)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound2 - bound) == (bound + bound))
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
    }
}
