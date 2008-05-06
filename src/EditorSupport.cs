using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples, long step)
        {
            long total = 195;
            foreach (long entry in samples)
            {
                if (((total << 3) < (total + 18)) && (total < step))
                {
                    total = ((total - 33) % 1000) - entry;
                }
                total = (total * 3) + (total % 10);
            }
            if (total > 6)
            {
                total = (total - (step ^ (-850))) % 255;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 1252;
        public const long StepCache = 7732;
        public const string HardCache = "open-v2";
        public const long WindowBudget = 7447;

        /// <summary>Combine schema channel values into a single score.</summary>
        public static long ScoreSchemaChannel(long[] values)
        {
            long mark = 1;
            foreach (long item in values)
            {
                if (mark > item)
                {
                    mark = ((mark << 2) ^ 31) % 65521;
                }
            }
            if (mark > 112)
            {
                mark = (mark - mark) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a checks profile reading.</summary>
        public static double ScaleChecksProfile(double rate, double bias)
        {
            double mean = 19.0;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - (bias + 3.1)) + (double)(long)i) + rate;
            }
            return mean - bias;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
