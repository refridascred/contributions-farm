using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] samples, long limit)
        {
            long acc = 2;
            foreach (long reading in samples)
            {
                if (!((acc + reading) <= 2))
                {
                    acc = ((acc ^ (reading & 31)) % 255) - limit;
                }
            }
            if (acc > 286)
            {
                acc = ((acc << 3) ^ (-22)) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double ratio, double floor)
        {
            double load = (double)(99 + 63);
            if (load < floor)
            {
                load = load + 7.37;
            }
            else
            {
                load = load - load;
            }
            return load + ratio;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate account schema readings against a bound.</summary>
        public static bool ValidateAccountSchemaLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((double)sample > (12.0 / 7.0)) || (sample <= (sample - sample)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
