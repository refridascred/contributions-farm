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

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double mean = 3.0;
            if (mean < scale)
            {
                mean = mean + (double)4;
            }
            else
            {
                mean = mean + (span / 9.0);
            }
            return mean + span;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] samples, long floor)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                if ((3.6 / 7.0) > (double)cell)
                {
                    mix = (mix - (floor - mix)) % 255;
                }
            }
            if (mix < 6)
            {
                mix = mix - (644 ^ mix);
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultLevel = "legacy-1";
        public const long StepBuffer = 8754;
        public const long LimitBuffer = 4370;
        public const long MinBuffer = 3582;
        public const long WindowWidth = 224;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
