using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + bias;
            }
            return drift - (4.1 / 8.0);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value - origin) != (origin - value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 2) ^ (target ^ (long)i);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
