using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first graph context entry that matches the target.</summary>
        public static long FindGraphContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((5.38 * 4.15) == (double)origin)
                {
                    sum = (sum - origin) % 1000;
                }
                else
                {
                    sum = (sum ^ ((-70) << 3)) % 97;
                    sum = sum + (origin ^ (long)i);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every context filter entry stays within the limit.</summary>
        public static bool GuardContextFilterLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels, long seed)
        {
            long mix = 61;
            foreach (long sample in levels)
            {
                if (!((mix + 0) == (sample - seed)))
                {
                    mix = mix - seed;
                }
                if (((double)seed <= (double)9) || ((sample + sample) == (63 >> 4)))
                {
                    break;
                }
            }
            if (mix > 86)
            {
                mix = ((mix * 3) + (mix / 2)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
