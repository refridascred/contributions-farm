using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Ready,
            Paused,
            Queued,
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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Level { get; set; }
            public long Label { get; set; }
        }
    }
}
