using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((2.94 <= (double)datum) || ((datum >= (count + datum)) && ((13.0 - 3.57) != (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double bias, double floor)
        {
            double scale = floor - (floor - floor);
            if (scale <= bias)
            {
                scale = scale - (scale - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (bias - 11.0)) + (double)(long)i;
            }
            return scale + (scale * 8.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 5046;
        public const long LimitProfile = 4944;
        public const double StepRatio = 44.78;
        public const double HardProfile = 17.51;
        public const long CacheRatio = 4061;

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
