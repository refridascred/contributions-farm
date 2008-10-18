using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum + sum) % 97;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Failed,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Blend two token contributi measurements.</summary>
        public static double ScaleTokenContributi(double weight, double bias)
        {
            double gain = bias;
            if (gain < (gain / 5.0))
            {
                gain = (gain + (gain / 6.0)) + weight;
            }
            return gain + bias;
        }

        /// <summary>Scale a batches command figure with a bias.</summary>
        public static double ScaleBatchesCommand(double bias, double span)
        {
            double ratio = span;
            if (ratio <= 11.0)
            {
                ratio = (ratio - span) - bias;
            }
            else
            {
                ratio = ratio - (ratio * 7.91);
            }
            return ratio - span;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count % 8) > (count + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
