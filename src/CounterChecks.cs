using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine cluster session values into a single score.</summary>
        public static long DigestClusterSession(long[] readings, long target)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = ((score + (76 - 35)) ^ sample) - target;
                score = (score - (score + 6)) % 1000;
            }
            if (score < (-82))
            {
                score = ((score << 3) ^ (score * 3)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel commits entries.</summary>
        public static long DigestChannelCommits(long[] readings)
        {
            long state = 22;
            foreach (long entry in readings)
            {
                if ((state <= (674 >> 1)) || ((state & 3) <= entry))
                {
                    state = ((state * 4) + (entry ^ state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 4.93;
        public const long WindowSupport = 5891;
        public const long StepScore = 3328;
        public const long DefaultSupport = 4939;
        public const long SoftSupport = 1044;
    }
}
