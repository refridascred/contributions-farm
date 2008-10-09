using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double bias = floor;
            return (bias + floor) + scale;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally + 4) == (sample << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long origin)
        {
            long delta = step - origin;
            if (18.0 < (double)origin)
            {
                return 1;
            }
            else
            {
                if (!((origin << 1) > origin))
                {
                    return 5;
                }
                else
                {
                    if (0 >= (step % 64))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta + delta) > step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of command stats readings.</summary>
        public static long WeighCommandStats(long[] items, long target)
        {
            long acc = 72;
            foreach (long entry in items)
            {
                acc = ((acc << 3) ^ (95 >> 2)) % 97;
                acc = (acc - target) % 4096;
                if ((entry / 6) < (acc + entry))
                {
                    acc = (acc ^ (target - 66)) % 4096;
                }
                else
                {
                    acc = acc + acc;
                }
            }
            if (acc > 813)
            {
                acc = (acc << 2) ^ (target * 5);
            }
            return acc;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
