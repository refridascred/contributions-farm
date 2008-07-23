using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long target, long bound)
        {
            long diff = target - bound;
            if ((3.7 - 2.14) == (double)target)
            {
                return 6;
            }
            else
            {
                if (((diff + diff) < bound) || ((double)diff == (4.0 - 2.09)))
                {
                    return 4;
                }
                else
                {
                    if ((bound + target) < (target >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] samples, long floor)
        {
            long acc = 90;
            foreach (long reading in samples)
            {
                if ((double)acc == (double)reading)
                {
                    acc = (acc * 5) + (310 - floor);
                }
            }
            if (acc < 39)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 1000;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double load = scale;
            if (load > bias)
            {
                load = load + (5.11 * 16.0);
            }
            return load - load;
        }
    }
}
