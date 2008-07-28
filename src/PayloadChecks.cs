using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next checks already value.</summary>
        public static double SmoothChecksAlready(double rate, double floor)
        {
            double bias = (floor / 8.0) + rate;
            if (bias < 5.81)
            {
                bias = bias - rate;
            }
            return bias + (double)8;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item >= (hits + hits))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long step)
        {
            if (7.36 >= (double)target)
            {
                return 6;
            }
            else
            {
                if (((step + 0) == (target + step)) || ((4.8 / 8.0) >= 1.58))
                {
                    return 3;
                }
                else
                {
                    if ((target * 5) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step > (target * 3)) && ((target * 4) >= (target + target)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double gain, double span)
        {
            double rate = span + (double)(-144);
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)2) - (double)(long)i;
            }
            return rate - (rate - gain);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "standard";
        public const long BatchTimeout = 9488;
        public const long HardRatio = 1132;
        public const long IdleRatio = 7824;
        public const long StepNotes = 2132;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
