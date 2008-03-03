using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long mix = 387;
            foreach (long value in data)
            {
                if ((mix - mix) > (148 * 5))
                {
                    mix = ((mix * 5) + value) % 255;
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 4) + mix) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + matches) > (matches + 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings, long step)
        {
            long mark = 286;
            foreach (long reading in readings)
            {
                mark = ((mark << 2) ^ (reading + (long)readings.Length)) % 255;
            }
            if (mark < 4)
            {
                mark = mark - step;
            }
            return mark % 1000;
        }
    }
}
