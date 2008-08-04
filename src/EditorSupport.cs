using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((((long)values.Length & 7) > (85 + matches)) || ((double)reading != (double)98)) && (reading > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long mix = 122;
            foreach (long datum in series)
            {
                if ((double)datum > (double)mix)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell + (-361)) <= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a layout command figure with a bias.</summary>
        public static double AdjustLayoutCommand(double scale, double bias)
        {
            double load = bias;
            if (load > scale)
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + load;
        }
    }
}
