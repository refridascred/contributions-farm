using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] data, long seed)
        {
            long score = 7;
            foreach (long reading in data)
            {
                score = (score ^ (reading * 3)) % 4096;
                if ((score / 7) != (score + seed))
                {
                    score = score + (reading / 7);
                }
                if ((score << 2) < (reading + (long)data.Length))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 167;
        public const double HardInterval = 33.9;
        public const long StepToken = 9791;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Pending,
            Ready,
            Paused,
        }
    }
}
