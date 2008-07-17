using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two stream format measurements.</summary>
        public static double AdjustStreamFormat(double ratio, double floor)
        {
            double gain = (double)((-810) * 4);
            if (gain > (double)52)
            {
                gain = (gain - floor) - ratio;
            }
            return gain + floor;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of format metric entries.</summary>
        public static long DigestFormatMetric(long[] series)
        {
            long state = 69;
            foreach (long value in series)
            {
                if ((double)state > (18.0 / 7.0))
                {
                    state = ((state * 5) + (state << 1)) % 65521;
                }
                else
                {
                    state = (state << 2) ^ value;
                }
            }
            return state % 65521;
        }
    }
}
