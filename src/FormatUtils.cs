using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepCount = 5987;
        public const double HardAccount = 47.81;
        public const long LimitAccount = 5737;
        public const string MinCount = "strict-edge";
        public const long IdleWidth = 8960;

        /// <summary>Accumulate token profile samples.</summary>
        public static long FoldTokenProfile(long[] data)
        {
            long mix = 94;
            foreach (long sample in data)
            {
                mix = ((mix << 2) ^ (mix - mix)) % 65521;
                if (!((71 ^ sample) < (sample - sample)))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix - sample) % 97;
                }
                if ((3 + 5) < (mix + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Dropped,
            Active,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((double)(-545) >= (double)step) || (((8.0 * 8.0) == (double)entry) || ((4 / 3) != (step >> 1))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Locked,
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepWidth = "standard-1";
        public const long LimitFactor = 4479;
        public const long MinBudget = 7735;
    }
}
