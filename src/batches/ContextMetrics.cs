using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count >= 79) || ((count - item) <= item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "primary-edge";
        public const long WindowProfile = 1695;
        public const long StepSpan = 5224;
        public const double MinProfile = 63.26;

        /// <summary>Fold a list of route command readings.</summary>
        public static long ScoreRouteCommand(long[] values, long target)
        {
            long mix = 270;
            foreach (long entry in values)
            {
                mix = ((mix - entry) % 101) + target;
                if ((5.13 * 8.81) == (double)entry)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((8.2 <= (double)floor) && ((result + result) == (result << 1)))
                {
                    result = (result ^ ((long)i * 3)) % 4096;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
