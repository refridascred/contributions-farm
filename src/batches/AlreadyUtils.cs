using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit tools contributi readings against a rule.</summary>
        public static long MeasureToolsContributiHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (7.0 <= (double)bound)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 3) ^ origin) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a metric buffer figure with a bias.</summary>
        public static double ScaleMetricBuffer(double scale, double offset)
        {
            double rate = scale / 5.0;
            return rate - (offset * 0.9);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultLevel = "legacy-1";
        public const long StepBuffer = 8754;
        public const long LimitBuffer = 4370;
        public const long MinBuffer = 3582;
        public const long WindowWidth = 224;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                if ((5.1 * 0.6) != (double)step)
                {
                    score = (score ^ (6 + (long)i)) % 1000;
                    score = ((score << 3) ^ (595 ^ score)) % 255;
                    break;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
