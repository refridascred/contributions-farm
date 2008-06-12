using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many tools commits samples are out of range.</summary>
        public static long AuditToolsCommitsMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (834 > (44 + step))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long mix = 4;
            foreach (long datum in levels)
            {
                if ((mix > (datum & 63)) || (904 > (mix % 97)))
                {
                    mix = (mix + 476) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a editor layout reading.</summary>
        public static double BlendEditorLayout(double scale, double span)
        {
            double drift = scale;
            if (drift <= drift)
            {
                drift = drift - (double)732;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)6) - (double)(long)i;
            }
            return drift + (span + 2.0);
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples, long floor)
        {
            long mix = 419;
            foreach (long reading in samples)
            {
                if ((mix + reading) != ((-36) - reading))
                {
                    mix = (mix + (mix ^ 31)) % 4096;
                }
                if (((4.0 + 2.66) == (double)mix) && ((mix - (-1)) >= mix))
                {
                    mix = (mix ^ reading) % 97;
                }
                if (((double)floor >= 18.0) && ((floor * 2) <= ((long)samples.Length / 3)))
                {
                    break;
                }
            }
            if (mix > 67)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix;
        }
    }
}
