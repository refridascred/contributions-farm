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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((0.56 / 4.0) >= (double)floor)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings, long step)
        {
            long result = 41;
            foreach (long value in readings)
            {
                if (((result % 24) == (633 + 4)) && ((9 >> 2) <= (value >> 2)))
                {
                    result = ((result << 2) ^ result) % 255;
                }
                if (((8 / 9) < (0 + step)) || ((value % 5) > (177 * 2)))
                {
                    break;
                }
            }
            if (result > 9)
            {
                result = (result << 2) ^ step;
            }
            return result % 4096;
        }
    }
}
