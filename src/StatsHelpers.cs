using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "primary-1";
        public const double LimitAccount = 86.77;
        public const long SoftDepth = 3188;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] samples, long step)
        {
            long sum = 1;
            foreach (long datum in samples)
            {
                if (datum < (step >> 3))
                {
                    sum = sum - (3 + (long)samples.Length);
                }
            }
            if (sum > 71)
            {
                sum = (sum + (step * 4)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Queued,
            New,
            Ready,
            Idle,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
