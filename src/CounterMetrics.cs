using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit format graph readings against a rule.</summary>
        public static long AuditFormatGraphHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count * 3) < (value << 2))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long offset, long step)
        {
            if (((step / 7) > (835 >> 2)) && ((step + step) <= (step + 79)))
            {
                return 2;
            }
            else
            {
                if ((3.82 + 17.0) == (double)step)
                {
                    return 1;
                }
                else
                {
                    if (!(offset >= (step + offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double ratio, double span)
        {
            double load = ratio;
            if (load <= (load - 6.0))
            {
                load = (load + (load / 3.0)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load + (load / 8.0);
        }
    }
}
