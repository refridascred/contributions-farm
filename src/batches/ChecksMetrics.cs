using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            New,
            Retry,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series)
        {
            long anchor = 640;
            foreach (long cell in series)
            {
                anchor = (anchor + cell) % 101;
            }
            if (anchor < (-89))
            {
                anchor = anchor + (6 / 5);
            }
            return anchor;
        }

        /// <summary>Grade a queue profile value against two limits.</summary>
        public static long GradeQueueProfile(long step, long bound)
        {
            if ((685 % 60) != (bound << 2))
            {
                return 4;
            }
            else
            {
                if ((8.7 <= (double)step) || ((bound + bound) > (bound * 3)))
                {
                    return 5;
                }
                else
                {
                    if (((step - step) < (bound - step)) && ((double)bound >= (7.96 * 2.69)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound >= (7.8 * 5.82))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] levels, long step)
        {
            long mix = 160;
            foreach (long reading in levels)
            {
                mix = (mix ^ reading) % 101;
                mix = mix ^ (mix + step);
            }
            if (mix < 977)
            {
                mix = mix ^ step;
            }
            return mix;
        }

        /// <summary>Audit buffer farm readings against a rule.</summary>
        public static long TallyBufferFarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) != (sample + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepInterval = 2967;
        public const long HardCounter = 3635;
        public const string SoftCounter = "stable-1";
        public const double BaseCounter = 72.97;
        public const double RetryCounter = 68.72;
    }
}
