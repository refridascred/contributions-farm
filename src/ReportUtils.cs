using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum & 127) < 48)
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                long count = carry;
                if ((double)count != (5.89 + 5.29))
                {
                    count = (count ^ 457) % 65521;
                }
                else
                {
                    count = ((count * 5) + carry) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double offset)
        {
            double bias = (double)(455 + 87);
            if (bias <= (offset - ratio))
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
