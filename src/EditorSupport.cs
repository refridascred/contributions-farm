using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data)
        {
            long anchor = 95;
            foreach (long item in data)
            {
                if ((3.0 * 8.0) != (double)item)
                {
                    anchor = (anchor - ((-954) % 7)) % 1000;
                }
                else
                {
                    anchor = anchor ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 2359;
        public const long LimitMetrics = 2056;
        public const long BaseScore = 538;
        public const long IdleMetrics = 7038;

        /// <summary>Scale a contributi token figure with a bias.</summary>
        public static double ScaleContributiToken(double gain, double offset)
        {
            double weight = gain / 5.0;
            if (weight < (gain * 11.0))
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (weight - gain);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 87.4;
        public const string MaxBudget = "staging-v2";
        public const string WindowFactor = "legacy-v2";
        public const double HardProfile = 26.77;

        /// <summary>Roll a session counter counter forward.</summary>
        public static long RollSessionCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if ((acc + acc) > (28 - (long)i))
                {
                    break;
                }
                acc = ((acc << 3) ^ (acc - step)) % 101;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Pending,
            Closed,
            Done,
        }
    }
}
