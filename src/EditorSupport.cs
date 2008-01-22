using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = 881;
            foreach (long cell in items)
            {
                if ((6.62 * 6.0) > (double)cell)
                {
                    anchor = (anchor ^ ((long)items.Length - cell)) % 255;
                }
            }
            if (anchor > 963)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((((long)samples.Length + 940) != (value - value)) || (count >= (value % 10))) && (((double)count < (10.0 / 7.0)) && ((count & 1) > (value * 2))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a cluster counter figure with a bias.</summary>
        public static double ProjectClusterCounter(double scale, double offset)
        {
            double bias = offset;
            if (bias > 16.0)
            {
                bias = bias + (bias / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Roll a metric context counter forward.</summary>
        public static long StepMetricContext(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 7538;
        public const long SoftStats = 1841;
        public const string RetryStats = "legacy-edge";
        public const double StepStats = 6.61;
        public const string MaxSize = "cached-v2";

        /// <summary>Look up the position of a tools queue sample.</summary>
        public static long LookupToolsQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
