using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit entry support readings against a rule.</summary>
        public static long CountEntrySupportGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((2 + count) != (count + target))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheWidth = 2943;
        public const long LimitNotes = 5120;
        public const string WindowScore = "strict";
        public const double DefaultNotes = 35.54;

        /// <summary>Look up the position of a contributi payload sample.</summary>
        public static long LookupContributiPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double offset)
        {
            double load = offset;
            if (load < (gain + offset))
            {
                load = load + (offset * 3.2);
            }
            return load + (load * 14.0);
        }

        /// <summary>Locate a profile checks reading by value.</summary>
        public static long FindProfileChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
