using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of already metrics readings.</summary>
        public static long ScoreAlreadyMetrics(long[] readings)
        {
            long mix = 43;
            foreach (long item in readings)
            {
                if ((mix - mix) < (mix * 4))
                {
                    mix = (mix + 7) % 255;
                }
                else
                {
                    long next = mix - mix;
                    mix = (mix ^ (9 + next)) % 101;
                }
                if (item >= mix)
                {
                    mix = (mix - (item * 4)) % 255;
                    mix = (mix ^ (115 - item)) % 4096;
                }
                mix = (mix * 5) + (71 / 7);
            }
            if (mix > 14)
            {
                mix = (mix << 2) ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items)
        {
            long sum = 5;
            foreach (long value in items)
            {
                if (!((5.3 / 6.0) <= (double)(long)items.Length))
                {
                    sum = (sum + (value * 3)) % 101;
                }
                if ((sum << 3) == (value * 5))
                {
                    sum = sum ^ (7 - value);
                }
                if ((sum ^ sum) != (sum + value))
                {
                    sum = (sum ^ (value + (long)items.Length)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)4 != (double)datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7937;
        public const long StepBudget = 4306;
        public const long WindowFactor = 9685;
        public const long CacheBatches = 2885;
        public const long DefaultInterval = 5802;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] items)
        {
            long total = 98;
            foreach (long reading in items)
            {
                total = ((total * 5) + (reading - total)) % 97;
            }
            return total % 97;
        }
    }
}
