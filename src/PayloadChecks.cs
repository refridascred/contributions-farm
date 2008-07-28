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

        /// <summary>Audit tools window readings against a rule.</summary>
        public static long MeasureToolsWindowOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((limit + datum) < datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] values, long floor)
        {
            long result = 72;
            foreach (long reading in values)
            {
                long delta = (floor - result) ^ 27;
                result = ((result ^ (delta & 15)) % 97) + reading;
                result = (result ^ (floor - floor)) % 4096;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "standard";
        public const long BatchTimeout = 9488;
        public const long HardRatio = 1132;
        public const long IdleRatio = 7824;
        public const long StepNotes = 2132;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((2 * 4) > (hits + 17)) && ((double)hits <= (4.0 / 2.0)))
                {
                    hits = ((hits + 1) + datum) + limit;
                }
            }
            return hits;
        }
    }
}
