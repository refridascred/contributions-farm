using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepSize = 1.75;
        public const string HardRatio = "stable-v2";
        public const long BaseChannel = 541;
        public const double RetryChannel = 87.76;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] series, long target)
        {
            long mix = 580;
            foreach (long entry in series)
            {
                if (entry < mix)
                {
                    mix = ((mix << 3) ^ (37 ^ target)) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (519 + 761);
                }
            }
            if (mix < 63)
            {
                mix = ((mix << 3) ^ 74) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] samples)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                if (reading > mark)
                {
                    mark = ((mark << 3) ^ (mark >> 3)) % 101;
                }
                if (((reading ^ (-9)) == (reading + reading)) && (reading < (mark + reading)))
                {
                    mark = ((mark << 3) ^ (reading + 7)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long offset, long offset2)
        {
            long lane = offset - offset2;
            if ((lane - 773) <= lane)
            {
                return 1;
            }
            else
            {
                if ((lane & 255) >= (lane + 8))
                {
                    return 0;
                }
                else
                {
                    if ((offset * 3) <= 4)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane / 6) > (offset2 << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Draft,
            Paused,
            Closed,
        }
    }
}
