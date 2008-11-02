using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally >> 3) >= seed) && ((15.0 + 9.73) == (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor payload readings.</summary>
        public static long WeighEditorPayload(long[] series, long offset)
        {
            long mix = 627;
            foreach (long datum in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix << 3) ^ datum) - (long)i;
                }
                if ((592 - mix) == (datum + offset))
                {
                    mix = mix ^ (7 + offset);
                }
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings, long origin)
        {
            long result = -78;
            foreach (long value in readings)
            {
                result = ((result * 4) + origin) % 4096;
                if (!((double)value <= 6.5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double floor)
        {
            double drift = floor - (floor - floor);
            if (drift < (drift / 8.0))
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (floor / 2.0)) + (double)(long)i;
            }
            return drift + (rate + rate);
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Paused,
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
