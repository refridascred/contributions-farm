using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 6925;
        public const long StepFormat = 341;
        public const double MaxDepth = 72.58;
        public const long BatchDepth = 572;

        /// <summary>Scale a already farm figure with a bias.</summary>
        public static double ScaleAlreadyFarm(double gain, double span)
        {
            double mean = span;
            if (mean >= mean)
            {
                mean = mean + (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (gain - span)) + (double)(long)i;
            }
            return mean + (double)4;
        }

        /// <summary>Fold a list of order token readings.</summary>
        public static long ScoreOrderToken(long[] data)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                if ((acc > reading) && ((reading & 3) >= acc))
                {
                    acc = (acc + (reading >> 5)) % 4096;
                }
            }
            return acc % 97;
        }
    }
}
