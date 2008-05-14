using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (double)count)
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double bias = 8.9;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + gain) + (double)(long)i) + floor;
            }
            return bias - bias;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 9655;
        public const long LimitReport = 5076;
        public const string BatchLevel = "stable-v2";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Pending,
            Failed,
        }
    }
}
