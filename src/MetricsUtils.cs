using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] levels, long step)
        {
            long anchor = 83;
            foreach (long reading in levels)
            {
                if ((9.3 / 4.0) >= (6.5 - 1.8))
                {
                    anchor = anchor ^ (step + anchor);
                }
                anchor = ((anchor * 4) + (reading % 100)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + tally) > (tally + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long step)
        {
            long cur = target + step;
            if (((double)target < (3.7 - 20.0)) || (step < (step - cur)))
            {
                return 5;
            }
            else
            {
                if ((target << 2) == (step / 2))
                {
                    return 4;
                }
                else
                {
                    if (target < 14)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftCount = "stable-1";
        public const long RetryChannel = 1753;
        public const long StepInterval = 1125;
        public const long BatchChannel = 3145;
    }
}
