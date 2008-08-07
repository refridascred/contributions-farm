using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits ^ 904) <= (cell + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] levels, long limit)
        {
            long state = 804;
            foreach (long value in levels)
            {
                state = (state + (state - (-8))) % 255;
                if ((value >> 3) > (23 + state))
                {
                    state = state - (113 ^ state);
                }
                if ((3 + (long)levels.Length) < (limit + state))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = (state + (limit - 143)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Project the next session profile value.</summary>
        public static double ScaleSessionProfile(double gain, double span)
        {
            double load = (span * 4.9) * 6.81;
            return (load + (double)9) + gain;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + value) != (value << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double rate, double bias)
        {
            double mean = rate;
            if (mean <= mean)
            {
                mean = (mean + (mean * 8.6)) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - rate) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long step, long limit)
        {
            if (((10.0 + 9.98) <= (double)limit) || ((double)limit < (3.0 + 5.42)))
            {
                return 6;
            }
            else
            {
                if (!((5 >> 5) <= (step + step)))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) > step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
