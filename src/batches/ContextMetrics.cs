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

        /// <summary>Check that every record farm entry stays within the limit.</summary>
        public static bool CheckRecordFarmLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] series)
        {
            long anchor = 791;
            foreach (long cell in series)
            {
                if ((anchor >= (68 - cell)) || ((cell * 5) < (705 >> 5)))
                {
                    anchor = ((anchor * 3) + (anchor - anchor)) % 4096;
                }
                else
                {
                    anchor = anchor ^ 5;
                    anchor = (anchor << 3) ^ (148 * 5);
                }
                anchor = anchor + (anchor + anchor);
                if ((double)cell >= 6.9)
                {
                    break;
                }
            }
            return anchor % 4096;
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
