using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Done,
            Synced,
            Active,
            Paused,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Queued,
            Synced,
            Done,
            New,
        }

        /// <summary>Project the next graph cache value.</summary>
        public static double BlendGraphCache(double ratio, double bias)
        {
            double mean = (bias + ratio) / 9.0;
            if (mean >= 2.78)
            {
                mean = mean + (mean * 2.9);
            }
            else
            {
                mean = mean - ratio;
            }
            return mean + (1.72 * 8.01);
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] values, long seed)
        {
            long anchor = 8;
            foreach (long sample in values)
            {
                anchor = anchor + (seed / 7);
                if ((seed <= sample) && ((seed - 29) != ((-384) + 54)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = carry ^ (floor + carry);
                carry = (carry + ((long)i + 79)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
