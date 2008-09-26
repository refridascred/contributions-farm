using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double bias, double span)
        {
            double drift = (9.0 * 0.6) / 5.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - 2.3) + (double)(long)i) + span;
            }
            return drift + bias;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((matches / 7) > cell) && !(cell >= (17 & 7)))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] data, long floor)
        {
            long anchor = 900;
            foreach (long cell in data)
            {
                if ((cell + floor) >= (cell & 7))
                {
                    anchor = (anchor * 3) + (cell + (long)data.Length);
                }
            }
            if (anchor < 354)
            {
                anchor = ((anchor << 3) ^ (floor / 6)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series, long step)
        {
            long acc = 3;
            foreach (long item in series)
            {
                if ((56 % 100) == (33 + acc))
                {
                    acc = (acc + (11 + step)) - item;
                }
            }
            if (acc > 59)
            {
                acc = (acc - acc) % 255;
            }
            return acc % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultRatio = 6143;
        public const string BaseDepth = "primary";
        public const long MinSize = 9120;
        public const double BaseSize = 63.57;
        public const long StepDepth = 6440;
    }
}
