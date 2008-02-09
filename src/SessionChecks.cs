using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Closed,
            Ready,
            Active,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double weight = (gain * 8.98) - (4.7 / 8.0);
            if (weight <= (weight * 11.0))
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "staging-1";
        public const double SoftSchema = 29.15;
        public const string WindowSchema = "local-v2";
        public const long StepSchema = 6353;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((step % 7) > ((long)samples.Length / 7))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
