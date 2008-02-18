using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long target, long floor)
        {
            long next = target ^ floor;
            if ((double)floor <= 9.96)
            {
                return 7;
            }
            else
            {
                if ((target >> 3) > (next * 5))
                {
                    return 0;
                }
                else
                {
                    if (floor > next)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((next < floor) && ((next & 127) <= (target ^ 66)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                if (mark <= 1)
                {
                    mark = (mark - (bound + bound)) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ ((long)i + bound);
                }
                mark = (mark - (bound * 4)) % 65521;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Locked,
            Stale,
            Done,
            Paused,
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
